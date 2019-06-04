using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Bertani
{
    public partial class HargaPasar : UserControl
    {
        //DateTime tanggalDari, tanggalKe;
        private string strTanggalDari, strTanggalKe;
        List<int> listHarga = new List<int>();
        List<string> listWaktu = new List<string>();
        public HargaPasar()
        {
            InitializeComponent();
        }
        private void GetData(string komoditas,string daerah)
        {
            listWaktu.Clear();
            listHarga.Clear();
            using (XmlReader reader = XmlReader.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\" + komoditas + ".xml")))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "Provinsi")
                        {
                            if (reader.GetAttribute(0) == daerah)
                            {
                                while (reader.Read())
                                {
                                    if (reader.IsStartElement() && reader.Name == strTanggalDari)
                                    {
                                        listWaktu.Add(reader.Name);
                                        listHarga.Add(reader.ReadElementContentAsInt());
                                        while (reader.Read())
                                        {
                                            if (reader.IsStartElement())
                                            {
                                                if (reader.Name != strTanggalKe)
                                                {
                                                    listWaktu.Add(reader.Name);
                                                    listHarga.Add(reader.ReadElementContentAsInt());
                                                }
                                                else
                                                {
                                                    listWaktu.Add(reader.Name);
                                                    listHarga.Add(reader.ReadElementContentAsInt());
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                reader.Skip();
                            }
                        }
                    }
                }
            }
        }
        private async Task TampilkanData(string komoditas, string daerah)
        {
            GetData(komoditas, daerah.ToUpper());
            crtHargaPasar.Series.Clear();
            crtHargaPasar.Titles.Clear();
            crtHargaPasar.Series.Add(komoditas);
            crtHargaPasar.Series[komoditas].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for(int i=0; i < listHarga.Count; i++)
            {
                crtHargaPasar.Series[komoditas].Points.AddXY(listWaktu[i], listHarga[i]);
            }
            crtHargaPasar.ChartAreas[0].AxisY.Minimum = listHarga.Min()-500;
            crtHargaPasar.Series[komoditas].Enabled = true;
            crtHargaPasar.Titles.Add("Harga " + komoditas + " di " + daerah);
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (cbKomoditasHP.Text != "" && cbDaerah.Text != "")
            {
                strTanggalDari = GetWaktu(dtpTanggalDari.Value);
                strTanggalKe = GetWaktu(dtpTanggalKe.Value);
                TampilkanData(cbKomoditasHP.Text, cbDaerah.Text);
            }
            else
                MessageBox.Show("Harap pilih Komoditas dan Daerah");
        }

        private string GetWaktu(DateTime waktu)
        {
            string returnStr = "";
            switch (waktu.Month)
            {
                case 1:
                    returnStr = "Jan";
                    break;
                case 2:
                    returnStr = "Feb";
                    break;
                case 3:
                    returnStr = "Mar";
                    break;
                case 4:
                    returnStr = "Apr";
                    break;
                case 5:
                    returnStr = "Mei";
                    break;
                case 6:
                    returnStr = "Jun";
                    break;
                case 7:
                    returnStr = "Jul";
                    break;
                case 8:
                    returnStr = "Agu";
                    break;
                case 9:
                    returnStr = "Sep";
                    break;
                case 10:
                    returnStr = "Okt";
                    break;
                case 11:
                    returnStr = "Nov";
                    break;
                case 12:
                    returnStr = "Des";
                    break;
            }
            returnStr += (waktu.Year - 2000).ToString();
            if (waktu.Day < 8)
                returnStr += "I";
            else if (waktu.Day < 16)
                returnStr += "II";
            else if (waktu.Day < 23)
                returnStr += "III";
            else
                returnStr += "IV";
            return returnStr;
        }

    }
}
