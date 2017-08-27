namespace IEXPath
{
    partial class frmIEXPath
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIEXPath));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.labletag = new System.Windows.Forms.Label();
            this.txtOuterHtml = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstXPath = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.chkSplit = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTag);
            this.groupBox1.Controls.Add(this.labletag);
            this.groupBox1.Controls.Add(this.txtOuterHtml);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHTML);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.Location = new System.Drawing.Point(68, 71);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(251, 21);
            this.txtTag.TabIndex = 5;
            this.txtTag.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // labletag
            // 
            this.labletag.AutoSize = true;
            this.labletag.Location = new System.Drawing.Point(39, 80);
            this.labletag.Name = "labletag";
            this.labletag.Size = new System.Drawing.Size(23, 12);
            this.labletag.TabIndex = 12;
            this.labletag.Text = "Tag";
            // 
            // txtOuterHtml
            // 
            this.txtOuterHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOuterHtml.Location = new System.Drawing.Point(68, 179);
            this.txtOuterHtml.Name = "txtOuterHtml";
            this.txtOuterHtml.Size = new System.Drawing.Size(251, 21);
            this.txtOuterHtml.TabIndex = 11;
            this.txtOuterHtml.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "OuterHTML";
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(68, 152);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(251, 21);
            this.txtText.TabIndex = 9;
            this.txtText.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Value";
            // 
            // txtHTML
            // 
            this.txtHTML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHTML.Location = new System.Drawing.Point(68, 125);
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.Size = new System.Drawing.Size(251, 21);
            this.txtHTML.TabIndex = 7;
            this.txtHTML.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "HTML";
            // 
            // txtClass
            // 
            this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClass.Location = new System.Drawing.Point(68, 98);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(251, 21);
            this.txtClass.TabIndex = 6;
            this.txtClass.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(68, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 21);
            this.txtName.TabIndex = 3;
            this.txtName.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(68, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(251, 21);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "双击文本框复制";
            this.txtID.DoubleClick += new System.EventHandler(this.txtID_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "XPath（选择后双击复制）";
            // 
            // lstXPath
            // 
            this.lstXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstXPath.FormattingEnabled = true;
            this.lstXPath.ItemHeight = 12;
            this.lstXPath.Items.AddRange(new object[] {
            "拖动左下角的图标到IE查看即可",
            "也可以按F8获取光标当前位置元素信息",
            "",
            "双击文本框即可复制内容",
            "XPATH选中后双击即可复制。采集时默认自动复制第一个",
            "",
            "Bug、建议或者检查新版本请点击右下角链接"});
            this.lstXPath.Location = new System.Drawing.Point(12, 243);
            this.lstXPath.Margin = new System.Windows.Forms.Padding(5);
            this.lstXPath.Name = "lstXPath";
            this.lstXPath.Size = new System.Drawing.Size(326, 100);
            this.lstXPath.TabIndex = 2;
            this.lstXPath.DoubleClick += new System.EventHandler(this.lstXPath_DoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by 晓风轻";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopy.Location = new System.Drawing.Point(53, 349);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(138, 16);
            this.chkCopy.TabIndex = 6;
            this.chkCopy.Text = "自动复制第一个XPath";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // chkSplit
            // 
            this.chkSplit.AutoSize = true;
            this.chkSplit.Location = new System.Drawing.Point(53, 371);
            this.chkSplit.Name = "chkSplit";
            this.chkSplit.Size = new System.Drawing.Size(114, 16);
            this.chkSplit.TabIndex = 7;
            this.chkSplit.Text = "XPath使用单引号";
            this.chkSplit.UseVisualStyleBackColor = true;
            this.chkSplit.CheckedChanged += new System.EventHandler(this.chkSplit_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // frmIEXPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 389);
            this.Controls.Add(this.chkSplit);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstXPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIEXPath";
            this.Text = "IEXPath";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIEXPath_FormClosed);
            this.Load += new System.EventHandler(this.frmIEXPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOuterHtml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstXPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label labletag;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.CheckBox chkSplit;
    }
}

