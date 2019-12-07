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
            Color color;
            Point point = MousePosition;

            IntPtr dc = CreateDC("Display", null, null, IntPtr.Zero);
            int pixel = GetPixel(dc, point.X, point.Y);

            positionX_Value.Text = point.X.ToString();
            positionY_Value.Text = point.Y.ToString();

            color = Color.FromArgb((pixel & 0x000000FF), (pixel & 0x0000FF00) >> 8, (pixel & 0x00FF0000) >> 16);

            DeleteDC(dc);

            string clrValue = String.Format("{0:X2}-{1:X2}-{2:X2}\n{3}-{4}-{5}", color.R, color.G, color.B, color.R, color.G, color.B);

            colorValue.Text = clrValue;

        }
        #endregion Timer OnTick
    }
}