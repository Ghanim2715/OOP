using System;
using System.Collections.Generic;
using System.Text;
using TugasOOP.Induk;
/*
namespace TugasOOP.Anak
{
    class karyawanharian : karyawan
    {
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }

        public override double gaji()
        {
            double jumlah = upahperjam * jumlahjamkerja;
            return jumlah;
        }
    }
}
*/
namespace TugasOOP.Anak

{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji() => UpahPerJam * JumlahJamKerja;
    }
}