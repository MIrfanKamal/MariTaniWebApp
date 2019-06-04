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
        public LahankuTambahForm(int i,string komoditas, decimal luasLahan, decimal hasilperHa, DateTime tanggal, decimal hargaBibit, decimal hargaPerawatan,Catatan catatan)
        {
            InitializeComponent();
            this.catatan = catatan;
            mode = Mode.Edit;
            lblJudul.Text = "Edit Lahan";
            btnTambah.Text = "Edit";
            this.i = i;
            cbKomoditas.Text = komoditas;
            tbLuasLahan.Text = luasLahan.ToString();
            tbHasilperHektar.Text = hasilperHa.ToString();
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
            if (cbKomoditas.Text != "" && tbLuasLahan.Text != "" && tbHasilperHektar.Text != "" && tbHargaBibit.Text != "" && tbBiayaPerawatan.Text != "" && cbDaerah.Text != "")
            {
                using (var db = new LahanModel())
                {
                    var result = db.Lahans.SingleOrDefault(k => k.Id == i);
                    if (result != null)
                    {
                        result.Komoditas = cbKomoditas.Text;
                        result.LuasLahan = Convert.ToDecimal(tbLuasLahan.Text);
                        result.HasilperHa = int.Parse(tbHasilperHektar.Text);
                        result.TanggalTanam = dtpTanggal.Value;
                        result.HargaBibit = Convert.ToDecimal(tbHargaBibit.Text);
                        result.HargaPerawatan = Convert.ToDecimal(tbBiayaPerawatan.Text);
                        result.Lokasi = cbDaerah.Text;
                        db.SaveChanges();
                        MessageBox.Show("Berhasil diperbaharui");
                    }
                }
            }
            else
                MessageBox.Show("Ada bagian yang kosong!");
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbKomoditas.Text != "" && tbLuasLahan.Text != "" && tbHasilperHektar.Text != "" && tbHargaBibit.Text != "" && tbBiayaPerawatan.Text != "" && cbDaerah.Text != "")
            {
                if (mode == Mode.Insert)
                    catatan.AddNewLahan(catatan.getID(), cbKomoditas.Text, Convert.ToDecimal(tbLuasLahan.Text), Convert.ToDecimal(tbHasilperHektar.Text), dtpTanggal.Value, Convert.ToDecimal(tbHargaBibit.Text), Convert.ToDecimal(tbBiayaPerawatan.Text), cbDaerah.Text);
                else if (mode == Mode.Edit)
                {
                    EditData(i);
                    catatan.EditLahan(i, cbKomoditas.Text, Convert.ToDecimal(tbLuasLahan.Text), Convert.ToDecimal(tbHasilperHektar.Text), dtpTanggal.Value, Convert.ToDecimal(tbHargaBibit.Text), Convert.ToDecimal(tbBiayaPerawatan.Text), cbDaerah.Text);
                }
                this.Close();
            }
            else
                MessageBox.Show("Ada bagian yang kosong!");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (cbKomoditas.Text != "" && tbLuasLahan.Text != "" && tbHasilperHektar.Text != "" && tbHargaBibit.Text != "" && tbBiayaPerawatan.Text != "" && cbDaerah.Text != "")
            {
                lblEstimasiPanen.Text = KelasLahan.HitungEstimasiPanen(dtpTanggal.Value,cbKomoditas.Text).ToLongDateString();
                lblEstimasiKeuntungan.Text = "Rp "+KelasLahan.HitungEstimasiKeuntungan(cbKomoditas.Text, Convert.ToDecimal(tbLuasLahan.Text), Convert.ToDecimal(tbHasilperHektar.Text), Convert.ToDecimal(tbHargaBibit.Text), Convert.ToDecimal(tbBiayaPerawatan.Text), cbDaerah.Text).ToString();
            }
            else
                MessageBox.Show("Ada bagian yang kosong!");
        }
    }
}
