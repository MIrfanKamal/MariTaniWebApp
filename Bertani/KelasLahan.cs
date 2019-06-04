using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bertani
{
    class KelasLahan
    {
        public int LahanId { get; set; }
        public string Komoditas { get; set; }
        public decimal LuasLahan { get; set; }
        public decimal HasilperHa { get; set; }
        public decimal HargaBibit { get; set; }
        public decimal HargaPerawatan { get; set; }
        public DateTime Tanggal { get; set; }
        public DateTime EstimasiPanen { get; set; }
        public decimal EstimasiKeuntungan { get; set; }
        public string Lokasi { get; set; }
        public KelasLahan(int lahanId,string komoditas,decimal luasLahan,decimal hasilperHa,DateTime tanggal,decimal hargaBibit,decimal hargaPerawatan,string lokasi)
        {
            LahanId = lahanId;
            Komoditas = komoditas;
            LuasLahan = luasLahan;
            HasilperHa = hasilperHa;
            Tanggal = tanggal;
            HargaBibit = hargaBibit;
            HargaPerawatan = hargaPerawatan;
            Lokasi = lokasi;
            EstimasiPanen = HitungEstimasiPanen(tanggal, komoditas);
            EstimasiKeuntungan = HitungEstimasiKeuntungan(komoditas, luasLahan, hasilperHa, hargaBibit, hargaPerawatan, lokasi);
        }
        public static DateTime HitungEstimasiPanen(DateTime tanggal, string komoditas)
        {
            switch (komoditas)
            {
                case "Beras":
                    tanggal=tanggal.AddDays(110);
                    break;
                case "Bawang Putih":
                    tanggal=tanggal.AddDays(90);
                    break;
                case "Bawang Merah":
                    tanggal=tanggal.AddMonths(2);
                    break;
                case "Cabai Merah":
                    tanggal=tanggal.AddMonths(3);
                    tanggal=tanggal.AddDays(15);
                    break;
                case "Cabai Rawit":
                    tanggal=tanggal.AddMonths(3);
                    tanggal=tanggal.AddDays(15);
                    break;
                case "Gula":
                    tanggal=tanggal.AddMonths(11);
                    break;
            }
            return tanggal;
        }
        public static decimal HitungEstimasiKeuntungan(string komoditas, decimal luasLahan, decimal hasilperHa, decimal hargaBibit, decimal hargaPerawatan,string lokasi)
        {
            int harga=0;
            string waktu = "Apr19V";
            decimal beratBersih = luasLahan * hasilperHa * 1000;
            using (XmlReader reader = XmlReader.Create(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\" + komoditas + ".xml")))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "Provinsi")
                        {
                            if (reader.GetAttribute(0) == lokasi.ToUpper())
                            {
                                while (reader.Read())
                                {
                                    if (reader.IsStartElement() && reader.Name == waktu)
                                    {
                                        harga = reader.ReadElementContentAsInt();
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
            return beratBersih * harga - hargaBibit - hargaPerawatan - beratBersih * 1500;
        }
    }
}
