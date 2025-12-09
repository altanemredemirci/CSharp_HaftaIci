namespace _09_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DÖNGÜLER - LOOPS
             * While
             * For
             * Do While
             * Foreach

             Döngüler; belirli bir kod bloğunun bir şarta bağlı olarak tekrarlı çalıştırılmasını sağlar.
             Mesela 1 - 10 aralığındaki sayıları ekrana yazdırmak istersek
             */

            #region WHILE LOOP
            /*
            while (koşul true olduğu sürece)
            {
                    //Kod bloğu
            }

            */
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i += 1;
            //}

            #region 250-50 aralığındaki sayıları ekrana yazdırınız

            //int i = 250;
            //while (i > 50)
            //{
            //    Console.WriteLine(i);
            //    i--; //i-=1;
            //}

            #endregion

            #region 250-50 aralığındaki sayılardan 3'ün katlarını ekrana yazdırınız

            //int i = 250;
            //while (i > 50)
            //{

            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }                

            //    i--; 
            //}

            #endregion

            #region 1-10 aralığındaki sayıların toplamını ekrana yazdırınız

            //int i = 1;

            //int toplam = 0;

            //while (i < 11)
            //{
            //    toplam = toplam + i; //toplam+=i;
            //    i++;
            //}

            //Console.WriteLine("Toplam:"+toplam);
            #endregion
            #region 1-100 aralığındaki tek sayıları ayrı çift sayıları ayrı toplayarak sonucunu ekrana yazdırınız

            //int i = 1;
            //int cifttoplam = 0;
            //int tektoplam = 0;

            //while (i < 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam += i;
            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine("Tek Sayıları Toplamı:"+tektoplam);
            //Console.WriteLine("Çift Sayıları Toplamı:"+cifttoplam);


            #endregion
            /*
             BREAK - CONTINUE

            Break:Döngüyü istenilen satırda kırar. 
            
            Continue:Okunduğu satırdan programı döngü koşul satırına gönderir.
             
            Sonsuz döngü:While koşulunun true olması ile döngü çalışır.Eğer koşul satırına true olarak data girilirse sonsuz döngü oluşur.
             
             */
            //int i = 1;
            //while (i < 10)
            //{
            //    if (i == 7)
            //    {
            //        break;
            //    }
            //    else if (i == 5)
            //    {
            //        i++;
            //        continue;
            //    }
            //        Console.WriteLine(i);
            //    i++;
            //}

            //while (true)
            //{
            //    Console.WriteLine("Devam etmek ister misiniz?(E/H)");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //}

            #region Kullanıcı 0 sayısını girene kadar alınan her sayıyı toplayan ve 0 girdiğin sonucu ekrana yazdıran while loop

            //int toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        //Console.WriteLine("Toplam:" + toplam);
            //        break;
            //    }

            //        toplam += sayi;

            //}
            //Console.WriteLine("Toplam:" + toplam);


            #endregion

            #region 0-500 aralığında tek sayıların toplayan ve ekrana yazan while döngüsü 

            //int i = 0;
            //int toplam = 0;
            //while (i < 500)
            //{
            //    if (i % 2 == 1)
            //    {
            //        toplam += i; //toplam=toplam+i;
            //    }

            //    i++;
            //}

            //Console.WriteLine("Toplam:"+toplam);




            //2.Yol
            //int i = 1;
            //int toplam = 0;
            //while (i < 500)
            //{
            //    toplam += i;
            //    i += 2;
            //}

            //Console.WriteLine("Toplam:" + toplam);

            #endregion


            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi isteyin
            //0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.           
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.

            //int toplam = 0;
            //int adet = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine("Pozitif Sayı giriniz");
            //    }
            //    else
            //    {
            //        toplam += sayi;
            //        adet++;
            //    }
            //}
            //Console.WriteLine("Toplam="+toplam);
            //Console.WriteLine("Ortalama="+(toplam/adet));



            #endregion


            #endregion

            #region FOR LOOP

            //1-10 aralığındaki sayıları ekrana yazdırın

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #region Kullanıcıdan başlangıç ve bitiş değerlerini alınız. bu aralıktaki sayıları ekrana yazdırınız

            //Console.WriteLine("Başlangıç:");
            //int basla = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitiş:");
            //int bitis = Convert.ToInt32(Console.ReadLine());


            //int toplam = 0;

            //for (int i = basla; i < bitis; i++)
            //{
            //    Console.WriteLine(i);
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            #endregion


            #region Kullanıcıdan alınan bir sayının faktöriyeli hesaplayan for döngüsünü yazınız.

            //5 => 1*2*3*4*5 => 120

            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int fakt = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    fakt *= i;
            //}

            //Console.WriteLine("Faktöriyel:"+fakt);

            #endregion

            #region 1-500 arasındaki sayıların içinden 13 katlarının kaç tane olduğunu ve toplamlarını hesaplayınız

            int toplam = 0;
            int adet = 0;

            for (int i = 1; i < 500; i++)
            {
                if (i % 13 == 0)
                {
                    toplam += i;
                    adet++;
                }
            }
            Console.WriteLine("Toplam:"+toplam);
            Console.WriteLine("Adet:"+adet);

            #endregion
            #endregion


        }
    }
}
