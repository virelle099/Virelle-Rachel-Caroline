using System;
using System.Collections.Generic;
using System.Text;
namespace Tugas5_Abstract
{
    public abstract class Employee
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NOKTP { get; }
        public Employee(string namaDepan, string namaBelakang, string noKTP)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NOKTP = noKTP;
        }
        public override string ToString() => $"{NamaDepan} {NamaBelakang}\n" +
            $"No KTP: {NOKTP}";
        public abstract decimal Pendapatan();
    }
}