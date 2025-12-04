using System.Runtime.ConstrainedExecution;

namespace _03_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TÜR DÖNÜŞÜMLERİ - CONVERSION
            //Belirli bir veri tipinin başka bir veri tipine dönüştürülmesidir. Genellikle kullanıcıdan Console.Readline() komutu ile data aldığımızda kullanılır.Çünkü Console.ReadLine() her zaman string tipinde data getirir(döndürür).


            /*
            1-Bilinçsiz Tür Dönüşümü
                *Genelde küçük veri tipinden büyük veri tipine dönüşümdür.Herhangi bir komut gerektirmez.
                int sayi = 10;
                double sayi2 = sayi; //double, int tipinden daha büyük değerleri alabildiği için hatasız dönüşüm olur.


            2-Bilinçli Tür Dönüşümü
                *Sözel-> Sayısal veya Sayısal->Sözel tür dönüşümüdür.Convert veya Parse komutları ile gerçekleştirilir.
                    
                    *StringToInt  
                      Console.WriteLine("1.sayıyı giriniz:");
                      int sayi =  Convert.ToInt32(Console.ReadLine());
                
                      Console.WriteLine("2.sayıyı giriniz:");
                      int sayi2 = int.Parse(Console.ReadLine());
                    
                    *IntToString
                        int sayi = 10;
                        string metin = sayi.ToString();
                        string metin2 = Convert.ToString(sayi);

                *BOXING :Büyük veri tipinden küçük veri tipine dönüşümdür.Büyük veri tipindeki değer küçük veri tipine sığacak boyutlarda ise yapılır.
             
                     double sayi = 15;
                     int sayi2 = (int)sayi;
             */


            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyadınız:");
            //string soyad = Console.ReadLine();

            //string adSoyad = ad + ' ' + soyad;


            //Console.WriteLine(adSoyad);


            string ad = "Altan";
            string soyad = "Emre";

            //Console.WriteLine("Ad Soyad:"+ad);
            //Console.WriteLine("Ad: "+ad+" Soyad:"+soyad);
            //Console.WriteLine($"Ad:{ad} Soyad:{soyad}");
            #endregion


            #region Kullanıcıdan 3 kardeşin yaşını alınız ve 3 kardeş yaşının toplamını ekrana yazdırınız
            //Console.Write("1. Kardeşin yaşı: ");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. Kardeşin yaşı: ");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("3. Kardeşin yaşı: ");
            //int yas3 = Convert.ToInt32(Console.ReadLine());

            //int toplam = yas1 + yas2 + yas3;
            //Console.WriteLine($"Yaşlar Toplamı: {toplam}");
            #endregion

            #region Kullanıcıdan alınan vize ve final notları üzerinden ortalamayı hesaplayarak ekrana yazdırınız.

            //Console.WriteLine("Vize notu:");
            //int vize = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final notu:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //double ortalama = vize * 0.4 + final * 0.6;


            //Console.WriteLine("Ortalama:"+ortalama); //+ operatörü string ile double değeri birleştirme.

            #endregion


            //int sayi1 = 10;
            //double sayi2 = 3;

            //Console.WriteLine(sayi1/sayi2);



        }
    }
}
