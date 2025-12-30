using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Metotlar_4
{
    internal class Diziler
    {
        //Erişim belirteci verilmeyen tanımlar default olarak private alır.
        //Static metotlar class üzerinden çağrılır.
        internal static void Doldur()
        {
            Console.WriteLine("Başlangıç:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş:");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç Sayı:");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet]; //Adet ile dizinin uzunluğu verip diziyi tanımladık.

            Random r = new Random(); //Rastgele sayı kütüphanesinden bir nesne aldık.

            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = r.Next(basla, bitis); //Verilen aralıkta rastgele bir sayı eklendi.
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }


        }


        //Nonstatic Metotları kullanmak için classtan bir nesne oluşturulur.
        internal void Doldur2()
        {
            Console.WriteLine("Başlangıç:");
            int basla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş:");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç Sayı:");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet]; //Adet ile dizinin uzunluğu verip diziyi tanımladık.

            Random r = new Random(); //Rastgele sayı kütüphanesinden bir nesne aldık.

            for (int i = 0; i < adet; i++)
            {
                sayilar[i] = r.Next(basla, bitis); //Verilen aralıkta rastgele bir sayı eklendi.
            }

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        internal static void TekCiftKontrol()
        {
            int[] sayilar = new int[15];

            DiziDoldur(sayilar); //sayilar dizisini 15 adet rastgele sayı ile doldurduk

            int[] tekler = new int[1];
            int[] ciftler = new int[1];

            int t = 0; int c = 0;


            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    ciftler[c] = sayi;
                    c++;
                    Array.Resize(ref ciftler, c+1);
                }
                else
                {
                    tekler[t] = sayi;
                    t++;
                    Array.Resize(ref tekler, t + 1);
                }
            }


        } 

        internal static void DiziDoldur(int[] ints)
        {
            Random r = new Random();

            for (int i = 0; i < 15; i++)
            {
                ints[i] = r.Next(1, 100);
            }

        }


    }
}
