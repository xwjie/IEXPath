using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace commonlib.winapi
{
	/// <summary>
	/// Windows API Functions
	/// </summary>
	public class Win32API
	{
		#region .ctor()
		// No need to construct this object
		private Win32API()
		{
		}
		#endregion
		
		#region CallBacks
		public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
		#endregion


        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);


        [DllImport("user32", EntryPoint = "RegisterWindowMessage")]
        public static extern int RegisterWindowMessage(
                string lpString
        );

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hwnd, int id, KeyModifiers fsModifiers, Keys
            vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id); 
        
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }

        public const int WM_HOTKEY = 0x0312;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassName(
            [In]IntPtr hWnd,
            [MarshalAs(UnmanagedType.VBByRefStr)]ref string IpClassName,
            [In]int nMaxCount
            );

        [DllImport("oleacc.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ObjectFromLresult(
            [In]int lResult,
            [In]ref Guid riid,
            [In]int wParam,
            [Out, MarshalAs(UnmanagedType.IUnknown)]out object ppvObject
            );



        [DllImport("user32.dll", EntryPoint = "SendMessageTimeoutA", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageTimeout(
            [In]IntPtr MSG,
            [In]int hWnd,
            [In]int wParam,
            [In]int lParam,
            [In]int fuFlags,
            [In]int uTimeout,
            [In, Out]ref int lpdwResult
            );

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr WindowFromPoint(
            [In]Point Point
            );

        public const int SMTO_ABORTIFHUNG = 2;

        public readonly static int WM_HTML_GETOBJECT = RegisterWindowMessage("WM_HTML_GETOBJECT");
        public readonly static Guid IID_IHTMLDocument = new Guid("626fc520-a41e-11cf-a731-00a0c9082637");

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags); 
    }

}
