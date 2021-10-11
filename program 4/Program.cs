using System;
using System.Collections.Generic;
namespace Tugas5_Abstract
{
    class Program
    {
        static void Main()
        {
            var gajiKaryawan = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            var kerjaKaryawan = new KerjaKaryawan("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisi = new Komisi("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var komisiPegawai = new KomisiPegawai("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Karyawan Diproses Secara Individual:\n");
            Console.WriteLine($"{gajiKaryawan}\nPendapatan: " +
                $"{gajiKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{kerjaKaryawan}\nPendepatan: " +
                $"{kerjaKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{komisi}\nPendapatan: " + $"{komisi.Pendapatan():C}");
            Console.WriteLine($"{komisiPegawai}\nPendapatan: " +
                $"{komisiPegawai.Pendapatan():C}");

            //membuat daftar <pegawai> dan inisialisasi dengan objek karyawan
            var employees = new List<Employee>() {gajiKaryawan,
                kerjaKaryawan, komisi, komisiPegawai};

            Console.WriteLine("Diproses dengan Polymorhphisme:\n");

            //memproses secara genetik setiap elemen dalam karyawan
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee); //memanggil ToString

                //menentukan apakah element itu adalah KomisiPegawai
                if (currentEmployee is KomisiPegawai)
                {
                    var employee = (KomisiPegawai)currentEmployee;
                    employee.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan kenaikan 10% adalah: " +
                        $"{employee.GajiPokok:C}");
                }
                Console.WriteLine($"Pendapatan: {currentEmployee.Pendapatan():C}\n");
            }
            for (int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine($"Pegawai {j} adalah {employees[j].GetType()}");
            }

        }
    }
}