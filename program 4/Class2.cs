using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Abstract
{
    public class Komisi : Employee
    {
        private decimal labaKotor;
        private decimal rateKomisi;
        public Komisi(string namaDepan, string namaBelakang, string noKTP,
            decimal labaKotor, decimal rateKomisi)
            : base(namaDepan, namaBelakang, noKTP)
        {
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
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(LabaKotor)} harus >= 0");
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(RateKomisi)} harus >  0 dan < 1");
                }
                rateKomisi = value;
            }
        }
        public override decimal Pendapatan() => rateKomisi * labaKotor;
        public override string ToString() =>
            $"Komisi Pegawai: {base.ToString()}\n" +
            $"Laba Kotor: {LabaKotor:C}\n" +
            $"Rate Komisi: {RateKomisi:F2}";
    }
}