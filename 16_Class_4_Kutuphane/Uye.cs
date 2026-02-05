using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Class_4_Kutuphane
{
    internal class Uye
    {
        public int UyeNo;
        public string AdSoyad;
        public List<Kitap> AldigiKitaplar;

        public static void Ekle(List<Uye> list)
        {
            Uye uye = new Uye();

            Console.WriteLine("No:");
            uye.UyeNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ad Soyad:");
            uye.AdSoyad = Console.ReadLine();

            uye.AldigiKitaplar = new List<Kitap>();

            list.Add(uye);
        }

        public static void Listele(List<Uye> list)
        {
            foreach (Uye item in list)
            {
                Console.WriteLine("Üye No:" + item.UyeNo);
                Console.WriteLine("Ad Soyad:" + item.AdSoyad);

                if (item.AldigiKitaplar.Count > 0)
                {
                    foreach (Kitap kitap in item.AldigiKitaplar)
                    {
                        Console.WriteLine("ISBN:" + kitap.ISBN);
                        Console.WriteLine("Kitap Adı:" + kitap.Ad);
                        Console.WriteLine("Yazar:" + kitap.Yazar);
                    }
                }

            }
        }


    }
}
