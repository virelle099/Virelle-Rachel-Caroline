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