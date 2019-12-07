#region Includes
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
#endregion Includes

namespace WhereIsMyCursor
{
    public partial class MainScreen : Form
    {
        #region GDI32 Imports
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDC(string strDriver, string strDevice,
                                             string strOutput, IntPtr pData);
        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll")]
        public static extern int GetPixel(IntPtr hdc, int x, int y);

        [DllImport("GDI32.dll")]
        public static extern bool BitBlt(int hdcDest, int nXDest, int nYDest,
                                         int nWidth, int nHeight, int hdcSrc,
                                         int nXSrc, int nYSrc, int dwRop);
        #endregion GDI Imports

        #region User32 Imports
        [DllImport("User32.dll")]
        public static extern int GetDesktopWindow();

        [DllImport("User32.dll")]
        public static extern int GetWindowDC(int hWnd);

        [DllImport("User32.dll")]
        public static extern int ReleaseDC(int hWnd, int hDC);
        #endregion User32 Imports

        #region Consturctor
        public MainScreen()
        {
            InitializeComponent();
        }
        #endregion Consturctor

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Start();
        }
        #endregion Form1_Load

        #region Timer OnTick
        void TimerOnTick(object obj, EventArgs e)
        {
            Point point = MousePosition;

            positionX_Value.Text = point.X.ToString();
            positionY_Value.Text = point.Y.ToString();
        }
        #endregion Timer OnTick
    }
}