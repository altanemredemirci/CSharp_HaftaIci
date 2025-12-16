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

            //int toplam = 0;
            //int adet = 0;

            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        toplam += i;
            //        adet++;
            //    }
            //}
            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Adet:"+adet);

            #endregion



            #endregion

            #region RANDOM

            //Belirli bir aralıkta rastgele sayı üretmeyi sağlar. Kullanıcının tanımladığı sayı aralığında int tipinde(tam sayı) sayılar üretir.

            //Random r = new Random(); //Random sınıfına ait bir nesne oluşturuldu.

            //int sayi = r.Next();
            //int sayi = r.Next(10);


            //while (true)
            //{
            //    int sayi = r.Next(5, 10);
            //    Console.WriteLine(sayi);
            //    Thread.Sleep(1000);
            //}




            #endregion

            /*
            SORU:1 - Bilgisayarın 1-100 aralığında bir sayıyı aklında tutmasını sağlayın.
            Kullanıcıya 5 hak vererek bu sayıyı tahmin etmesini isteyin
            Tahmini yönlendirerek kullanıcıya rehber olunuz.
            5. hakkını kullandığı ve bilmediği durumda hakkınız bitti yazsın.
             */
            //Random rnd = new Random();

            //int sayi = rnd.Next(1, 100);

            //for (int hak = 5; hak > 0; hak--)
            //{
            //    Console.WriteLine("Tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == sayi)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        break;
            //    }
            //    else if (hak == 1)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    else if (tahmin > sayi)
            //    {
            //        Console.WriteLine("Tahmininizi küçültünüz.");
            //    }
            //    else if (tahmin < sayi)
            //    {
            //        Console.WriteLine("Tahmininizi büyültünüz.");
            //    }
            //}

            /*
            int hak = 5;

            while (hak > 0)
            {
                Console.WriteLine("Tahmininiz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (tahmin == sayi)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                else if (hak == 1)
                {
                    Console.WriteLine("Hakkınız Bitti");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Tahmininizi küçültünüz.");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Tahmininizi büyültünüz.");
                }
            }
            */

            /*
            SORU:2 Aşağıdaki geometrik şekilleri for döngüsü ile ayrı ayrı kodlayınız.

            *
            **
            ***
            ****
            *****
            ******
            */

            //for (int i = 1; i < 7; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            /*
            *************
            *           *
            *           *
            *           *
            *           *
            *           *
            *************
            */

            //for (int i = 0; i < 7; i++)
            //{
            //    if(i==0 || i == 6)
            //    {
            //        Console.WriteLine("************");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*          *");
            //    }
            //}


            /*
                *
               ***
              *****
             *******
            *********
           ***********
          *************
            */



            //int bosluk = 10;

            //for (int i = 1; i < 20; i+=2)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 0; j<i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk--;
            //}

            /*

          SORU:3- Çarpım tablosunu for döngüsü ile ekrana yazdırınız.

            1x1=1  2x1=2  ....
            1x2=2  2x2=4
            1x3=3
            .....
             */
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Console.Write($"{j}x{i}={i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            #region Kullanıcının girmiş olduğu sayının asal olup olmadığını ekrana yazdıran döngü.
            //Asal Sayı:1 ve kendisinden başka sayıya tam bölünmeyen sayılara ASAL SAYI denir.
            //En küçük asal sayı:2
            //2,3,5,7,11,13,...

            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi < 2)
            //{
            //    Console.WriteLine("Asal Değildir");
            //}
            //else if (sayi == 2)
            //{
            //    Console.WriteLine("Asaldır");
            //}
            //else
            //{
            //    bool AsalMi = true;
            //    for (int i = 2; i < sayi; i++) //9
            //    {
            //        if (sayi % i == 0)
            //        {
            //            AsalMi = false;
            //            break;
            //        }
            //    }

            //    if (AsalMi == true)
            //    {
            //        Console.WriteLine("Asaldır");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Asal Değildir");
            //    }

            //}

            #endregion

            #region 1-1000000 arasındaki asal sayıları ekrana yazdırınız.

            //for (int sayi = 1; sayi < 1000; sayi++)
            //{

            //    if (sayi < 2)
            //    {
            //        continue;
            //    }
            //    else if (sayi == 2)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    else
            //    {
            //        bool AsalMi = true;
            //        for (int i = 2; i < sayi; i++) //9
            //        {
            //            if (sayi % i == 0)
            //            {
            //                AsalMi = false;
            //                break;
            //            }
            //        }

            //        if (AsalMi == true)
            //        {
            //            Console.WriteLine(sayi);
            //        }

            //    }
            //}






            #endregion


            #region DO WHILE

            //int i = 1;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<10);


            //Kullanıcı 0 değerini girene kadar girilen sayıları topla. 0 değerini girdiğinde toplama işlemini bitir ve sonucu ekrana yaz.


            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //        break;
            //    toplam += sayi;
            //}
            //Console.WriteLine(toplam);

            int toplam = 0;
            int sayi;

            do
            {
                Console.WriteLine("Sayı:");
                sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi;

            } while (sayi!=0);

            Console.WriteLine("Toplam:"+toplam);
            #endregion

        }
    }
}
