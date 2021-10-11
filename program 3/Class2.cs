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