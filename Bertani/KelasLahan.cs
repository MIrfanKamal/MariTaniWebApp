using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bertani
{
    class KelasLahan
    {
        private int _lahanId;
        private string _komoditas;
        private decimal _luasLahan;
        private int _jumlahTanaman;
        private DateTime _tanggal;
        private decimal? _hargaBibit;
        private decimal? _hargaPerawatan;
        public int LahanId
        {
            get { return _lahanId; }
            set { _lahanId = value; }
        }
        public string Komoditas
        {
            get { return _komoditas; }
            set { _komoditas = value; }
        }
        public decimal LuasLahan
        {
            get { return _luasLahan; }
            set { _luasLahan = value; }
        }
        public int JumlahTanaman
        {
            get { return _jumlahTanaman; }
            set { _jumlahTanaman = value; }
        }
        public decimal? HargaBibit
        {
            get { return _hargaBibit; }
            set { _hargaBibit = value; }
        }
        public decimal? HargaPerawatan
        {
            get { return _hargaPerawatan; }
            set { _hargaPerawatan = value; }
        }
        public DateTime Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; }
        }
        public KelasLahan(int lahanId,string komoditas,decimal luasLahan,int jumlahTanaman,DateTime tanggal,decimal? hargaBibit,decimal? hargaPerawatan)
        {
            LahanId = lahanId;
            Komoditas = komoditas;
            LuasLahan = luasLahan;
            JumlahTanaman = jumlahTanaman;
            Tanggal = tanggal;
            HargaBibit = hargaBibit;
            HargaPerawatan = hargaPerawatan;
        }
    }
}
