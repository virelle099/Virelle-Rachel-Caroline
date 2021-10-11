using System;
using System.Collections.Generic;
using System.Text;
public class KomisiPegawai : Komisi
{
    private decimal gajiPokok; // gaji pokok per minggu
    public KomisiPegawai(string namaDepan, string namaBelakang, string noKTP,
            decimal labaKotor, decimal rateKomisi, decimal gajiPokok)
            : base(namaDepan, namaBelakang, noKTP, labaKotor, rateKomisi)
    {
        gaji = gajiPokok; //validasi gaji pokok
    }
    public decimal gaji
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
                    value, $"{nameof(gaji)} harus >= 0");
            }
            gajiPokok = value;
        }
    }
    public override decimal Menghasilkan() => gaji + base.Menghasilkan();
    public override string ToString() =>
        $"Gaji {base.ToString()}\nGaji: {gaji:C}";
}

using System;
public class Komisi
{
    public string NamaDepan { get; }
    public string NamaTerakhir { get; }
    public string NOKTP { get; }
    protected decimal labaKotor; //laba mingguan
    protected decimal rateKomisi; // persentase komisi

    //5-paramater construction
    public Komisi(string namaDepan, string namaTerakhir, string noKTP,
        decimal labaKotor, decimal rateKomisi)
    {
        //pemanggilan object constructor
        NamaDepan = namaDepan;
        NamaTerakhir = namaTerakhir;
        NOKTP = noKTP;
        LabaKotor = labaKotor;
        RateKomisi = rateKomisi;
    }
    //setter dan getter
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
    public virtual decimal Menghasilkan() => rateKomisi * labaKotor;
    public override string ToString() =>
        $"Komisi Pegawai:  { NamaDepan } { NamaTerakhir}\n" +
        $"Nomer KTP: {NOKTP}\n" +
        $"Laba Kotor: {labaKotor:C}\n" +
        $"Rate Komisi: {rateKomisi:F2}\n";
}

using System;
public class Pegawai : Komisi
{
    private decimal gajiPokok;
    public Pegawai(string namaDepan, string namaBelakang, string noKTP,
        decimal labaKotor, decimal rateKomisi, decimal gajiPokok)
        : base(namaDepan, namaBelakang, noKTP, labaKotor, rateKomisi)
    {
        Gaji = gajiPokok; //validasi gaji pokok
    }
    public decimal Gaji
    {
        get
        {
            return gajiPokok;
        }
        set
        {
            if (value < 0) // validasi
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Gaji)} harus >= 0");
            }
            gajiPokok = value;
        }
    }
    //menghitung pendapatan
    public override decimal Menghasilkan() =>
        gajiPokok + (rateKomisi * labaKotor);
    //mengembalikan reprsentasi string dari KomisiPegawai
    public override string ToString() =>
        $"Komisi Gaji Pegawai: {NamaDepan} {NamaTerakhir}\n" +
        $"Nomer KTP: {NOKTP}\n" +
        $"Laba Kotor: {labaKotor:C}\n" +
        $"Rate Komisi: {rateKomisi:F2}\n" +
        $"Gaji Pokok: {gajiPokok}";
}

using System;
namespace Tugas5_Hirarki_Inheritance
{
    class Polymorphism
    {
        static void Main()
        {
            var Komisi = new Komisi("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            var Pegawai = new Pegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);
            Console.WriteLine("Memanggil Komisi ToString and Menghasilkan methods " +
                "dengan referensi kelas dasar ke objek kelas dasar");
            Console.WriteLine(Komisi.ToString());
            Console.WriteLine($"Menghasilkan: {Komisi.Menghasilkan()}\n");
            //aktifkan ToString dan Earnings pada objek kelas turunan
            //menggunakan kelas dasar
            Console.WriteLine("Memanggil KomisiPegawai ToString and Menghasilkan methods " +
                "dengan referensi kelas turunan");
            Console.WriteLine(Pegawai.ToString());
            Console.WriteLine($"Menghasilkan: {Pegawai.Menghasilkan()}\n");
            Komisi karyawan = Pegawai;
            Console.WriteLine(karyawan.ToString());
            Console.WriteLine($"Menghasilkan: {Pegawai.Menghasilkan()}\n");
        }
    }
}