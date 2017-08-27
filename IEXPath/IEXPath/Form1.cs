using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using commonlib.winapi;
using mshtml;

/**
 * IE下获取XPATH的工具
 * 
 * 作者：晓风轻
 * 知乎：https://www.zhihu.com/people/xiaofengqing/activities
 * GITHUB：https://github.com/xwjie
 * 
 * LICENSE：https://github.com/xwjie/IEXPath/blob/master/LICENSE
 * 
 * 时间：2017.8 重写
 */

namespace IEXPath
{
    public partial class frmIEXPath : Form
    {

        public int hotkeyId = 0;

        private Cursor moveCursor = null;

        private const string _VERSION = "1.0";

        public frmIEXPath()
        {
            InitializeComponent();
        }

        //重写消息循环
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Win32API.WM_HOTKEY && m.WParam.ToInt32() == this.hotkeyId) //判断热键
            {
                captureIE();
            }

            base.WndProc(ref m);
        }

        private void frmIEXPath_Load(object sender, EventArgs e)
        {
            this.Text = "IEXPath - " + _VERSION ;
            this.moveCursor = new Cursor(new System.IO.MemoryStream(Properties.Resources.pen_r));
            Win32API.SetWindowPos(this.Handle, -1, 0, 0, 0, 0, 1 | 2);

            if (! Win32API.RegisterHotKey(this.Handle, this.hotkeyId, commonlib.winapi.Win32API.KeyModifiers.None, Keys.F8))
            {
                MessageBox.Show("热键注册失败");
            }
        }

        private void frmIEXPath_FormClosed(object sender, FormClosedEventArgs e)
        {
            Win32API.UnregisterHotKey(this.Handle, this.hotkeyId);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/xwjie/IEXPath");
        }

        public static object GetComObjectByHandle(int Msg, Guid riid, IntPtr hWnd)
        {
            object _ComObject;
            int lpdwResult = 0;
            if (!Win32API.SendMessageTimeout(hWnd, Msg, 0, 0, Win32API.SMTO_ABORTIFHUNG, 1000, ref lpdwResult))
                return null;
            if (Win32API.ObjectFromLresult(lpdwResult, ref riid, 0, out _ComObject))
                return null;
            return _ComObject;
        }

        public object GetHtmlDocumentByHandle(IntPtr hWnd)
        {
            string buffer = new string('\0', 24);
            Win32API.GetClassName(hWnd, ref buffer, 25);

            if (buffer != "Internet Explorer_Server")
                return null;

            return GetComObjectByHandle(Win32API.WM_HTML_GETOBJECT, Win32API.IID_IHTMLDocument, hWnd);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            captureIE();
        }

        private void captureIE()
        {
            try
            {
                IntPtr hWnd = Win32API.WindowFromPoint(MousePosition);

                mshtml.IHTMLDocument2 doc2 = (mshtml.IHTMLDocument2)GetHtmlDocumentByHandle(hWnd);

                if (doc2 != null)
                {
                    Point point = MousePosition;

                    Win32API.ScreenToClient(hWnd, ref point);

                    IHTMLElement element = doc2.elementFromPoint(point.X, point.Y);

                    readIEElement(element);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("发生了一些错误：" + e.Message);
            }
        }

        private IHTMLElement lastEle = null;

        
        /**
         * 读取元素基本信息和提取XPATH
         */
        private void readIEElement(IHTMLElement e)
        {
            
            if (lastEle == e)
            {
                return;
            }

            clearBorderHint();

            this.lastEle = e;

            if (e == null)
            {
                return;
            }

            //画红框
            e.style.setAttribute("outline", "2px solid red");

            // 基本信息
            this.txtID.Text = e.id;
            this.txtName.Text = getElementAttribute(e, "NAME");
            this.txtTag.Text = e.tagName;
            this.txtText.Text = getElementAttribute(e, "VALUE");
            this.txtClass.Text = e.className;
            this.txtHTML.Text = e.innerHTML;
            this.txtOuterHtml.Text = e.outerHTML;

            // xpath
            extractXPath(e);

        }

        private char SPLIT = '"';

        private void extractXPath(IHTMLElement e)
        {
            lstXPath.Items.Clear();

            // id 
            if (e.id != null)
            {
                addXPath( "//*[@id=" + SPLIT + e.id + SPLIT + "]");
                return;
            }

            //往上找
            addXPath(getXPathEx(e));

            // name
            string name = getElementAttribute(e, "NAME");
            
            if (name != "")
            {
                addXPath("//" + e.tagName + "[@name=" + SPLIT + name + SPLIT + "]");
            }

            //class
            if (e.className != null)
            {
                /*
                String[] classnames = e.className.Split(' ');

                foreach (string cls in classnames)
                {
                    addXPath("//" + e.tagName + "[@class=" + SPLIT + cls + SPLIT + "]");
                }
                 */

                addXPath("//" + e.tagName + "[@class=" + SPLIT + e.className + SPLIT + "]");
            }

            // 自动复制第一个
            if (chkCopy.Checked)
            {
                Clipboard.SetText(lstXPath.Items[0].ToString());
            }

        }

        /**
         * 一直往上找，找到有id的父元素为止，如果没有，就到html为止。
         * 
         * 返回格式如：
         * //*[@id="formConfig"]/INPUT[1]
         * /HTML/BODY/DIV[1]/DIV/DIV[1]/A[1]/SPAN
         */
        private string getXPathEx(IHTMLElement e)
        {
            IHTMLElement current = e;

            string xpath = "";

            while (current != null)
            {
                // 如果有id，结束
                if (current.id != null)
                {
                    xpath = "//*[@id=" + SPLIT + current.id + SPLIT + "]" + xpath;
                    break;
                }
                else{
                    string currentXpath = extractCurrentXpath(current);
                    xpath =  currentXpath + xpath;
                }

                current = current.parentElement;
            }

            return xpath;
        }

        /**
         * 当前节点的xpath
         * 返回结果如: /INPUT[2]
         */ 
        private string extractCurrentXpath(IHTMLElement current)
        {
            string currentXpath = "/" + current.tagName;

            // 计算index
            int index = calculate(current);

            if (index >= 1)
            {
                currentXpath += "[" + index + "]";
            }

            return currentXpath;
        }

        /**
         * 计算当前元素在父元素中相同的tag中的index
         * xpath的index是从1开始的
         */ 
        private int calculate(IHTMLElement current)
        {
            if (current.parentElement == null) 
            {
                return 0;
            }

            IHTMLElementCollection collection = (IHTMLElementCollection)current.parentElement.children;

            int length = collection.length;

            int index = 0, all = 0;

            for (var i = 0; i < length; i++)
            {
                IHTMLElement item = collection.item(i);

                // 实际测试中发生过
                if (item == null) 
                { 
                   break; 
                }

                if (item.tagName == current.tagName)
                {
                    all++;

                    if (item == current)
                    {
                        index = all ;
                    }
                }               
            }

            // 只有一个元素，就不需要[1]
            if (all == 1)
            {
                return 0;
            }

            // xpath不是从0开始
            return index;
        }

        private void addXPath(string str)
        {
            lstXPath.Items.Add(str);
        }

        private string getElementAttribute(IHTMLElement e, string name)
        {
            dynamic value = e.getAttribute(name);
            return value is System.DBNull ? "" : value + "";
        }

        private void chkSplit_CheckedChanged(object sender, EventArgs e)
        {
            SPLIT = chkSplit.Checked ? '\'' : '"';
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            this.Cursor = this.moveCursor;
            //pictureBox1.Hide();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            //pictureBox1.Show();
            this.Cursor = Cursors.Default;
            clearBorderHint();
        }

        /**
         * 去掉最后一个元素的红框 
         **/
        private void clearBorderHint()
        {
            // 
            if (this.lastEle != null)
            {
                try
                {
                    this.lastEle.style.setAttribute("outline", "");
                }
                catch
                {
                    //上一个元素可能不存在了
                }
            }
        }

        private void txtID_DoubleClick(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            Clipboard.SetText(txt.Text);
        }

        private void lstXPath_DoubleClick(object sender, EventArgs e)
        {
            if (lstXPath.SelectedIndex == -1)
            {
                return;
            }

            Clipboard.SetText(lstXPath.SelectedItem.ToString());
        }

    }
}
