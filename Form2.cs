using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace A90Winlock
{
    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;

        public Form2()
        {
            InitializeComponent();

            this.TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int currentStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);

            SetWindowLong(this.Handle, GWL_EXSTYLE, currentStyle | WS_EX_TRANSPARENT);
            
        }
    }
}
