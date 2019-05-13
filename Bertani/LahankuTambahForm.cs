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
    public partial class LahankuTambahForm : Form
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
        private enum Mode{ Insert, Edit };
        Mode mode;
        Catatan catatan = new Catatan();
        DateTime date1 = new DateTime(2008, 3, 1, 7, 0, 0);
        private int i;
        public LahankuTambahForm()
        {
            InitializeComponent();
        }
        public LahankuTambahForm(Catatan catatan)
        {
            InitializeComponent();
            this.catatan = catatan;
            mode = Mode.Insert;
            lblJudul.Text = "Tambah Lahan";
            btnTambah.Text = "Tambah";
        }
        public LahankuTambahForm(int i,string komoditas, decimal luasLahan, int jumlahTanaman, DateTime tanggal, decimal? hargaBibit, decimal? hargaPerawatan,Catatan catatan)
        {
            InitializeComponent();
            this.catatan = catatan;
            mode = Mode.Edit;
            lblJudul.Text = "Edit Lahan";
            btnTambah.Text = "Edit";
            this.i = i;
            cbKomoditas.Text = komoditas;
            tbLuasLahan.Text = luasLahan.ToString();
            tbJumlahTanaman.Text = jumlahTanaman.ToString();
            dtpTanggal.Value = tanggal;
            tbHargaBibit.Text = hargaBibit.ToString();
            tbBiayaPerawatan.Text = hargaPerawatan.ToString();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditData(int i)
        {
            using(var db = new LahanModel())
            {
                var result = db.Lahans.SingleOrDefault(k => k.Id == i);
                if (result != null)
                {
                    result.Komoditas = cbKomoditas.Text;
                    result.LuasLahan = Convert.ToDecimal(tbLuasLahan.Text);
                    result.JumlahTanaman = int.Parse(tbJumlahTanaman.Text);
                    result.TanggalTanam = dtpTanggal.Value;
                    result.HargaBibit = Convert.ToDecimal(tbHargaBibit.Text);
                    result.HargaPerawatan = Convert.ToDecimal(tbBiayaPerawatan.Text);
                    db.SaveChanges();
                    MessageBox.Show("Berhasil diperbaharui");
                }
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                catatan.AddNewLahan(cbKomoditas.Text, Convert.ToDecimal(tbLuasLahan.Text), int.Parse(tbJumlahTanaman.Text), dtpTanggal.Value, Convert.ToDecimal(tbHargaBibit.Text), Convert.ToDecimal(tbBiayaPerawatan.Text));
            else if (mode == Mode.Edit)
            {
                EditData(i);
                catatan.EditLahan(i, cbKomoditas.Text, Convert.ToDecimal(tbLuasLahan.Text), int.Parse(tbJumlahTanaman.Text), dtpTanggal.Value, Convert.ToDecimal(tbHargaBibit.Text), Convert.ToDecimal(tbBiayaPerawatan.Text));
            }    
            this.Close();
        }
    }
}
