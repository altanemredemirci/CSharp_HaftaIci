using System.Diagnostics.CodeAnalysis;

namespace _12_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             METOTLAR - FONKSİYONLAR

             Metotlar:Yazılımcıların kendileri ve diğer yazılımcılar için yazıp kullanıma sundukları hazır kod tanımlarıdır. Bir başlık altında bir işlem yapmak için kodlanan yazılım yapılarıdır.

            Metotlar () şeklinde tanımlanır.
            Metotlar tanımlanırken içe içe tanımlanamazlar.
            Metotlar tanımlandıktan sonra çağrılmadıkları sürece çalışmazlar.
            Metotlar tıpkı değişkenler gibi UNIQUE(Benzersiz) isimde olmalılar.Aynı isimde tanımlı metotları metot imzaları ayırır.


            Metotlar 2'ye ayrılır.
            *Değer Döndüren (parametreli/parametresiz)
            *Değer Döndürmeyen (parametreli/parametresiz)

             */

            //Console.WriteLine("Altan Emre"); //parametreli
            //Console.ReadLine(); //parametresiz

            //Convert.ToInt32(Console.ReadLine()); //parametreli
            Convert.ToInt32("12"); //parametreli

            //Parametre:Metot parantezleri içerisinde yazılan ve metodu kullanırken gönderilecek verileridir.

            #region DEĞER DÖNDÜRMEYEN METOTLAR 

            //void anahtar kelimesi ile tanımlanırlar. İşlemi yaptıktan sonra çağrıldıkları yere bir değer taşımazlar.

            //Console.WriteLine("İsim gir"); //Değer döndürmeyen metot
            //string isim = Console.ReadLine(); ////Değer döndüren metot

            //void kelimesi ile tanımlanan ve işlem sonucu bir değer taşımayan metotlara denir.


            // void MetotAdı()
            // {
            // işlem kodu
            // }


            //*** Metot Çağırma
            //Yaz();



            //***PARAMETRESİZ METOT
            //Toplama();

            Toplama2();


            //***PARAMETRELİ METOT
            Console.WriteLine("1.Sayı Gir:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı Gir:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            ToplamaParametreli(sayi2, sayi1);


            int toplam =Toplama2();

            Console.WriteLine(toplam);
            #endregion

        }

        static void Yaz()
        {           
            Console.WriteLine("Altan Emre");            
        }
        
        
        static void Toplama()
        {
            Console.WriteLine("1.Sayı Gir:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı Gir:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç:"+(sayi1+sayi2));
        }


        static void ToplamaParametreli(int s1,int s2)
        {
            Console.WriteLine("Sonuç:" + (s1 + s2));
        }

        static int Toplama2()
        {
            Console.WriteLine("1.Sayı Gir:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı Gir:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int sonuc =sayi1 + sayi2;

            return sonuc;
        }
        
    }

}
