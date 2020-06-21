using System;
using System.Collections.Generic;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //deklarasi objek
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2715";
            karyawanTetap.Nama = "Muhammad";
            karyawanTetap.GajiBulanan = 8000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "80.40.8585";
            karyawanHarian.Nama = "Ghanim";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 200000;

            Sales sales = new Sales();
            sales.Nik = "20.70.50";
            sales.Nama = "Marsudi";
            sales.JumlahPenjualan = 100;
            sales.Komisi = 3000;
            

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            

            //loop
            int nomor = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}.NIK: {1}\nNama: {2} \nGaji: {3:N0}\n",
                    nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nomor++;
            }
            

           

        }
    }
}