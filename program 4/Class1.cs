using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Abstract
{
    public class KomisiPegawai : Komisi
    {
        private decimal gajiPokok;
        public KomisiPegawai(string namaDepan, string namaBelakang, string noKTP,
            decimal labaKotor, decimal rateKomisi, decimal gajiPokok)
            : base(namaDepan, namaBelakang, noKTP, labaKotor, rateKomisi)
        {
            GajiPokok = gajiPokok;
        }
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        public override decimal Pendapatan() => GajiPokok + base.Pendapatan();
        public override string ToString() =>
            $"gaji pokok {base.ToString()}\nGaji: {GajiPokok:C}";
    }
}