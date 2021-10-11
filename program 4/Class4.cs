using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Abstract
{
    public class GajiKaryawan : Employee
    {
        private decimal gajiMingguan;
        public GajiKaryawan(string namaDepan, string namaBelakang, string noKTP,
            decimal gajiMingguan)
            : base(namaDepan, namaBelakang, noKTP)
        {
            GajiMingguan = gajiMingguan;
        }
        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }
        public override decimal Pendapatan() => GajiMingguan;
        public override string ToString() =>
            $"Gaji Karyawan: {base.ToString()}\n" +
            $"Gaji Mingguan: {GajiMingguan:C}";
    }
}