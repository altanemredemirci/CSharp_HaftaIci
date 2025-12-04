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
           
            int toplam = 0;

            while (true)
            {
                Console.WriteLine("Sayı:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                {
                    //Console.WriteLine("Toplam:" + toplam);
                    break;
                }
                else
                {
                    toplam += sayi;
                }
            }
            Console.WriteLine("Toplam:" + toplam);


            #endregion






            #endregion




        }
    }
}
