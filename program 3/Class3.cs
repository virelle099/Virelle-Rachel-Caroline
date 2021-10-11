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