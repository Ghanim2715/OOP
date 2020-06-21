using System;
using System.Collections.Generic;
using System.Text;
using TugasOOP.Induk;
/*
namespace TugasOOP.Anak
{
    public class KaryawanTetap : karyawan
    {
        public double gajibulanan { get; set; }
        public override double Gaji ()
        {
            return gajibulanan;
        }
    }
}

*/
namespace TugasOOP.Anak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji() => GajiBulanan;
    }
}