using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Bertani
{
    public partial class TipsAndTrick : UserControl
    {
        public TipsAndTrick()
        {
            InitializeComponent();
        }

        private void btnPupuk_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\pupuk.pdf"));
            Process.Start(startInfo);
        }

        private void btnTanah_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\tanah.pdf"));
            Process.Start(startInfo);
        }

        private void btnIrigasi_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\irigasi.pdf"));
            Process.Start(startInfo);
        }

        private void btnSanitasi_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\sanitasi.pdf"));
            Process.Start(startInfo);
        }

        private void btnHama_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\hama.pdf"));
            Process.Start(startInfo);
        }

        private void btnAsuransi_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\asuransi.pdf"));
            Process.Start(startInfo);
        }
    }
}
