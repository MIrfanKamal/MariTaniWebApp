using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bertani
{
    public partial class Catatan : UserControl
    {
        List<KelasLahan> listLahan;
        List<Label> listLabelKomoditas;
        List<Label> listLabelLuasLahan;
        List<Label> listLabelJumlahTanaman;
        List<Label> listLabelTanggalTanam;
        List<Button> listBtnEdit;
        List<Button> listBtnHapus;
        List<PictureBox> listPb;
        Bitmap bmpBeras = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icon\rice_icon.png"));
        Bitmap bmpCabai = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icon\chilli_icon.png"));
        Bitmap bmpBawangPutih = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icon\garlic_icon.png"));
        Bitmap bmpBawangMerah = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icon\onion_icon.png"));
        Bitmap bmpGula = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icon\sugarcane_icon.png"));
        int halaman = 0;
        bool Calling = true;
        //DateTime date1 = new DateTime(2008, 3, 1, 7, 0, 0);

        public Catatan()
        {
            InitializeComponent();
            //GetLahan();
            listLabelKomoditas = new List<Label>() { lblKomoditas1, lblKomoditas2, lblKomoditas3, lblKomoditas4 };
            listLabelLuasLahan = new List<Label>() { lblLuasLahan1, lblLuasTanam2, lblLuasTanam3, lblLuasTanam4 };
            listLabelJumlahTanaman = new List<Label>() { lblJumlahTanaman1, lblJumlahTanaman2, lblJumlahTanaman3, lblJumlahTanaman4 };
            listLabelTanggalTanam = new List<Label>() { lblTanggalTanam1, lblTanggalTanam2, lblTanggalTanam3, lblTanggalTanam4 };
            listBtnEdit = new List<Button>() { btnEdit1, btnEdit2, btnEdit3, btnEdit4 };
            listBtnHapus = new List<Button>() { btnHapus1, btnHapus2, btnHapus3, btnHapus4 };
            listPb = new List<PictureBox>() { pb1, pb2, pb3, pb4 };

            //AddNewLahan("Beras", 200, 100, date1, 200, 100);
            //AddNewLahan("Beras", 100, 100, date1, 100, 100);
        }
        public void AddNewLahan(string komoditas, decimal luasLahan, int jumlahTanaman, DateTime tanggal, decimal? hargaBibit, decimal? hargaPerawatan)
        {
            using(var db = new LahanModel())
            {
                Lahan lahan = new Lahan
                {
                    Id = listLahan.Count,
                    Komoditas = komoditas,
                    LuasLahan = luasLahan,
                    JumlahTanaman = jumlahTanaman,
                    TanggalTanam = tanggal,
                    HargaBibit = hargaBibit,
                    HargaPerawatan = hargaPerawatan
                };
                db.Lahans.Add(lahan);
                db.SaveChanges();
                MessageBox.Show("Lahan berhasil ditambah");
            }
            //MessageBox.Show(listLahan.Count.ToString());
            KelasLahan newLahan = new KelasLahan(listLahan.Count, komoditas, luasLahan, jumlahTanaman, tanggal, hargaBibit, hargaPerawatan);
            listLahan.Add(newLahan);
            CheckLahan(halaman);
        }
        public void EditLahan(int i,string komoditas, decimal luasLahan, int jumlahTanaman, DateTime tanggal, decimal? hargaBibit, decimal? hargaPerawatan)
        {
            listLahan[i].Komoditas = komoditas;
            listLahan[i].LuasLahan = luasLahan;
            listLahan[i].JumlahTanaman = jumlahTanaman;
            listLahan[i].Tanggal = tanggal;
            listLahan[i].HargaBibit = hargaBibit;
            listLahan[i].HargaPerawatan = hargaPerawatan;
            CheckLahan(halaman);
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            LahankuTambahForm lahankuTambahForm = new LahankuTambahForm(this);
            lahankuTambahForm.Show();
        }

        public void GetLahan()
        {
            if (Calling)
            {
                Calling = false;
                KelasLahan newLahan;
                listLahan = new List<KelasLahan>();
                using (var db = new LahanModel())
                {
                    var query = from l in db.Lahans select l;
                    foreach (var item in query)
                    {
                        newLahan = new KelasLahan(item.Id, item.Komoditas, item.LuasLahan, item.JumlahTanaman, item.TanggalTanam, item.HargaBibit, item.HargaPerawatan);
                        listLahan.Add(newLahan);
                    }
                }
                CheckLahan(halaman);
            }
        }
        private void CheckLahan(int halaman)
        {
            int k = halaman * 4;
            if (k + 3 < listLahan.Count)
            {
                for(int i = k; i <= k + 3; i++)
                {
                    DisplayLahan(halaman,i, true);
                }
            }
            else if (k + 2 < listLahan.Count)
            {
                for(int i = k; i <= k + 2; i++)
                {
                    DisplayLahan(halaman,i, true);
                }
                DisplayLahan(halaman,k + 3, false);
            }
            else if (k + 1 < listLahan.Count)
            {
                for (int i = k; i <= k + 1; i++)
                {
                    DisplayLahan(halaman,i, true);
                }
                for (int i = k + 3; i > k + 1; i--)
                {
                    DisplayLahan(halaman,i, false);
                }
            }
            else if (k < listLahan.Count)
            {
                DisplayLahan(halaman,k, true);
                for (int i = k + 3; i > k; i--)
                {
                    DisplayLahan(halaman,i, false);
                }
            }
            if (4 + halaman * 4 < listLahan.Count)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
            if (-1 + halaman * 4 > 0)
                btnPrev.Enabled = true;
            else
                btnPrev.Enabled = false;
        }
        private void DisplayLahan(int halaman, int nomor,bool ada)
        {
            int i = halaman * 4;
            if (ada)
            {
                switch (listLahan[nomor].Komoditas)
                {
                    case "Beras":
                        listPb[nomor - i].Image = bmpBeras;
                        break;
                    case "Bawang Putih":
                        listPb[nomor - i].Image = bmpBawangPutih;
                        break;
                    case "Bawang Merah":
                        listPb[nomor - i].Image = bmpBawangMerah;
                        break;
                    case "Cabai Merah":
                        listPb[nomor - i].Image = bmpCabai;
                        break;
                    case "Cabai Rawit":
                        listPb[nomor - i].Image = bmpCabai;
                        break;
                    case "Gula":
                        listPb[nomor - i].Image = bmpGula;
                        break;
                }
                listLabelKomoditas[nomor-i].Text = listLahan[nomor].Komoditas;
                listLabelLuasLahan[nomor-i].Text = ": " + listLahan[nomor].LuasLahan.ToString();
                listLabelJumlahTanaman[nomor-i].Text = ": " + listLahan[nomor].JumlahTanaman.ToString();
                listLabelTanggalTanam[nomor-i].Text = ": " + listLahan[nomor].Tanggal.ToString();
                listBtnEdit[nomor-i].Enabled = true;
                listBtnHapus[nomor-i].Enabled = true;
            }
            else
            {
                listPb[nomor - i].Image = null;
                listLabelKomoditas[nomor-i].Text = "-";
                listLabelLuasLahan[nomor-i].Text = ": -";
                listLabelJumlahTanaman[nomor-i].Text = ": -";
                listLabelTanggalTanam[nomor-i].Text = ": -";
                listBtnEdit[nomor-i].Enabled = false;
                listBtnHapus[nomor-i].Enabled = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            halaman++;
            CheckLahan(halaman);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            halaman--;
            CheckLahan(halaman);
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            int i = listBtnEdit.IndexOf((Button)sender)+halaman*4;
            //MessageBox.Show(i.ToString());
            //MessageBox.Show(listLahan.Count.ToString());
            LahankuTambahForm lahankuTambahForm = new LahankuTambahForm(i, listLahan[i].Komoditas, listLahan[i].LuasLahan, listLahan[i].JumlahTanaman, listLahan[i].Tanggal, listLahan[i].HargaBibit, listLahan[i].HargaPerawatan,this);
            lahankuTambahForm.Show();
        }

        private void btnHapus1_Click(object sender, EventArgs e)
        {
            int i = listBtnHapus.IndexOf((Button)sender) + halaman * 4;
            using (var db = new LahanModel())
            {
                db.Lahans.RemoveRange(db.Lahans.Where(item => item.Id == i));
                db.SaveChanges();
            }
            listLahan.RemoveAt(i);
            CheckLahan(halaman);
        }
    }
}
