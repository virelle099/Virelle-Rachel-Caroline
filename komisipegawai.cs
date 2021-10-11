using System;

namespace Tugas5_Inheritance
{
    class KomisiPegawai
    {
        public static void Main()
        {
            var pegawai = new Komisi("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            //menampilkan data pegawai
            Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama Depan: {pegawai.NamaDepan}");
            Console.WriteLine($"Nama Terakhir: {pegawai.NamaTerakhir}");
            Console.WriteLine($"No KTP: {pegawai.NOKTP}");
            Console.WriteLine($"Laba: {pegawai.LabaKotor:C}");
            Console.WriteLine($"Rate Komisi: {pegawai.RateKomisi:F2}");
            Console.WriteLine($"Menghasilkan: {pegawai.Menghasilkan():C}");
            pegawai.LabaKotor = 5000.00M;
            pegawai.RateKomisi = .1M;
            Console.WriteLine("\nMemperbarui Informasi Pegawai diperoleh dari ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Menghasilkan: {pegawai.Menghasilkan():C}");
        }
    }
}