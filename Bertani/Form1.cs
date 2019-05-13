using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bertani
{
    public partial class formMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public formMain()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            home.BringToFront();
            catatan.GetLahan();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHome.Top;
            home.BringToFront();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnTutorial.Top;
            tipsAndTrick.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHargaPasar_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnHargaPasar.Top;
            hargaPasar.BringToFront();
        }

        private void btnLahanku_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnLahanku.Top;
            catatan.BringToFront();
        }

        private void btnTentangKami_Click(object sender, EventArgs e)
        {
            sidePanel.Top = btnTentangKami.Top;
            tentangKami.BringToFront();
        }
    }
}
