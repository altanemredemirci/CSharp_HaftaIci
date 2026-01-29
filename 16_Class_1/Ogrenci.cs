using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Class_1
{
    //class tanımları default olarak internal tipinde erişime sahiptir.
    class Ogrenci
    {
        //sınıfa ait property
        internal int Numara; //default olarak class a özel tanımlardır. yani private tanımlıdır.
        internal string Ad;
        internal string Soyad;

        internal static void Kayit(List<Ogrenci> liste)
        {
            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();

            Console.WriteLine("Numara:");
            ogrenci.Numara = Convert.ToInt32(Console.ReadLine());

            liste.Add(ogrenci);
        }

    }
}
