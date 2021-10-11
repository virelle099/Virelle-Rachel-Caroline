using System;
using System.Collections.Generic;
using System.Text;
namespace Tugas5_Abstract
{
    public class KerjaKaryawan : Employee
    {
        private decimal upah; //upah per jam
        private decimal jam; // jam kerja selama seminggu
        public KerjaKaryawan(string namaDepan, string namaBelakang, string noKTP,
            decimal upahJam, decimal jamKerja)
            : base(namaDepan, namaBelakang, noKTP)
        {
            Upah = upahJam;
            Jam = jamKerja;
        }
        //setter dan getter
        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Upah)} harus >= 0");
                }
                upah = value;
            }
        }
        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Jam)} harus >= 0");
                }
                jam = value;
            }
        }
        //menghitung pendapatan;
        public override decimal Pendapatan()
        {
            if (Jam <= 40)
            {
                return Upah * Jam;
            }
            else
            {
                return (40 * Upah) + ((Jam - 40) * Upah * 1.5M);
            }
        }
        public override string ToString() =>
            $"Jam Kerja Karyawan: {base.ToString()}\n" +
            $"Upah Per Jam: {Upah:C}\nJam Kerja: {Jam:F2}";
    }
}