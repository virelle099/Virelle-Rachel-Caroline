using System;
namespace Tugas5_Inheritance
{
    public class Komisi : object
    {
        public string NamaDepan { get; }
        public string NamaTerakhir { get; }
        public string NOKTP { get; }
        private decimal labaKotor;
        private decimal rateKomisi;
        //Constructor
        public Komisi(string namaDepan, string namaTerakhir, string noKTP, decimal labaKotor,
            decimal rateKomisi)
        {
            NamaDepan = namaDepan;
            NamaTerakhir = namaTerakhir;
            NOKTP = noKTP;
            LabaKotor = labaKotor;
            RateKomisi = rateKomisi;
        }
        public decimal LabaKotor
        {
            get
            {
                return labaKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(LabaKotor)} harus >= 0");
                }
                labaKotor = value;
            }
        }
        public decimal RateKomisi
        {
            get
            {
                return rateKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(rateKomisi)} harus > 0 dan < 1");
                }
                rateKomisi = value;
            }
        }
        //menghitung pembayaran komisi pegawai
        public decimal Menghasilkan() => labaKotor * rateKomisi;
        public override string ToString() =>
        $"Komisi Pegawai: { NamaDepan } { NamaTerakhir}\n" +
        $"Nomer KTP: {NOKTP}\n" +
        $"Laba Kotor: {labaKotor:C}\n" +
        $"Rate Komisi: {rateKomisi:F2}";
    }
}