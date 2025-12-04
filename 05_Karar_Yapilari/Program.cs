namespace _05_Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KARAR YAPILARI - CONDITION
            /*
             * If Else
             * Switch Case

             */

            #region IF ELSEIF ELSE
            //Kod içerisinde true veya false olarak cevaplanacak ve kodun bu cevaba hareket edeceği karşılaştırma(koşul) durumlarında kullanılır.
            // * Her zaman ilk koşul if ile kontrol edilir.
            // * If dışında kalan koşullar için else if kullanılır.
            // * If ve else if dışında kalan kontrol edilmeyen her koşul için else kullanılır. 
            // * else alternatif koşullar için kullanılır bu sebeple koşul komutu almaz.


            //Kullanıcıdan bir sayı alınız ve alınan sayının negatif,pozitif veya 0 kontrolünü yapınız.
            /*
            1-Başla
            2-sayi=Kullanıcan sayı alınız
            3-alınan sayıyı int çevir.
            4-Eğer sayi>0 ise Ekrana Pozitif yaz
            5-Değilse eğer sayi<0 ise Ekrana Negatif yaz
            6-Değilse Ekrana 0 yaz
            7-Bitti
             */


            //Console.WriteLine("Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Pozitif");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatif");
            //}
            ////else
            ////{
            ////    Console.WriteLine("Sayı 0");
            ////}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı 0");
            //}

            #region Haftanın kaçıncı gününde olduğumuzu kullanıcıdan alınız. Girilen sayıya göre gün ismini ekrana yazdırınız.

            //Console.WriteLine("Haftanın gün bilgisi giriniz:");
            //int day = Convert.ToInt32(Console.ReadLine());

            //if (day == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (day == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (day == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (day == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (day == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (day == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı gün bilgisi");
            //}
            #endregion

            #region Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            /*
            1-Başla
            2-urun1=birinci ürün fiyatı
            3-urun2=ikinci ürün fiyatı
            4-toplam=urun1+urun2
            5-Eğer toplam>2500 ise 
                5.1-Eğer urun1>urun2 ise urun2*0.75
                5.2-Değilse urun1<urun2 ise urun1*0.75
                5.3-toplam=urun1+urun2
            6-Ekrana toplamı yazdır
             */

            //Console.WriteLine("1.Ürün Fiyatı:");
            //double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün Fiyatı:");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());
            //double toplam = fiyat1 + fiyat2;

            //if (toplam > 2500)
            //{
            //    if (fiyat1 > fiyat2)
            //    {
            //        fiyat2 = fiyat2 * 0.75;
            //    }
            //    else
            //    {
            //        fiyat1 = fiyat1 * 0.75;
            //    }
            //    toplam = fiyat1 + fiyat2;
            //}

            //Console.WriteLine("Toplam Ödemeniz:"+toplam);


            //2.Yol
            //if (toplam > 2500)
            //{
            //    toplam = fiyat1 > fiyat2 ? (fiyat2 * 0.75) + fiyat1 : (fiyat1 * 0.75) + fiyat2;
            //}

            //Console.WriteLine("Toplam Ödemeniz:" + toplam);

            #endregion

            #region SORU3:
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            //Console.WriteLine("Geliriniz:");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    gelir = gelir * 0.88;
            //}
            //else
            //{
            //    gelir = gelir * 0.91;
            //}

            //Console.WriteLine("Net Geliriniz:"+gelir);

            #endregion

            #region SORU4:
            //  Harcanan m3 istenilecek ve
            //0 - 100 harcamışsa 0.35 ile fiyatlandırılacak
            //101 - 250=> 0.38 üzerinde hesaplandırılacak
            //251 - 400=> 0.41 üzerinde
            //401 - 600=> 0.42
            //600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek

            //Console.WriteLine("Harcanan m3 ne kadar?");
            //int harcanan = Convert.ToInt32(Console.ReadLine());

            //double odeme = 0;

            //if(harcanan>=0 && harcanan < 101)
            //{
            //    odeme = harcanan * 0.35;
            //}
            //else if(harcanan>100 && harcanan < 251)
            //{
            //    odeme = harcanan * 0.38;
            //}
            //else if (harcanan > 250 && harcanan < 401)
            //{
            //    odeme = harcanan * 0.41;
            //}
            //else if (harcanan > 400 && harcanan < 601)
            //{
            //    odeme = harcanan * 0.42;
            //}
            //else
            //{
            //    odeme = (harcanan * 0.43) - 120;
            //}

            //Console.WriteLine("Ödemeniz:"+odeme);
            #endregion

            #region SORU5:
            //# SORU: Kullanıcıdan alınan vize ve final notlarının ortalamasını vize%40 final%60 üzerinden  hesaplayınız.
            //# Ortalamaya göre harf notunu kullanıcıya bildiriniz.
            //#0-24 FF
            //#25-44 DD
            //#45-54 CC
            //#55-69 CB
            //#70-84 BB
            //#85 AA

            //VIZE:
            //    Console.WriteLine("Vize:");
            //    double vize = Convert.ToDouble(Console.ReadLine());

            //    if(vize<0 || vize > 100)
            //    {
            //        Console.WriteLine("Hatalı Vize Notu!");
            //        goto VIZE;
            //    }


            //FINAL:
            //    Console.WriteLine("Final:");
            //    double final = Convert.ToDouble(Console.ReadLine());

            //    if(final<0 || final > 100) //0<vize<100 veya 0<final<100
            //    {
            //        Console.WriteLine("Hatalı Fianl Notu!");
            //        goto FINAL;
            //    }
            //    else
            //    {
            //        double ortalama = vize * 0.4 + final * 0.6;

            //        if(ortalama>=0 && ortalama < 25)
            //        {
            //            Console.WriteLine("FF");
            //        }
            //        else if(ortalama>24 && ortalama < 45)
            //        {
            //            Console.WriteLine("DD");
            //        }
            //        else if (ortalama > 44 && ortalama < 55)
            //        {
            //            Console.WriteLine("CC");
            //        }
            //        else if (ortalama > 54 && ortalama < 70)
            //        {
            //            Console.WriteLine("CB");
            //        }
            //        else if (ortalama > 69 && ortalama < 85)
            //        {
            //            Console.WriteLine("BB");
            //        }
            //        else
            //        {
            //            Console.WriteLine("AA");
            //        }

            //    }



            #endregion

            #region Aşağıda belirtilen username ve password ile kullanıcının 3 defa giriş hak verilerek giriş yapmasını isteyelim. 3 hakkının birinde başarılı giriş yaparsa "GİRİŞ BAŞARILI", 3 hakkı bittiğinde "HAKKINIZ BİTTİ" ve her yanlış girişinde "TEKRAR DENEYİNİZ" yazdıralım

            //    string username = "admin";
            //    string password = "123";
            //    int hak = 3;

            //DON:
            //    if (hak > 0)
            //    {
            //        Console.WriteLine("Username:");
            //        string kullaniciAdi = Console.ReadLine();

            //        Console.WriteLine("Şifre:");
            //        string sifre = Console.ReadLine();


            //        if (username == kullaniciAdi && password == sifre)
            //        {
            //            Console.WriteLine("GİRİŞ BAŞARILI");
            //        }
            //        else
            //        {
            //            Console.WriteLine("TEKRAR DENEYİNİZ");
            //            hak--;
            //            goto DON;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("HAKKINIZ BİTTİ");
            //    }

            #endregion
            #endregion

            #region SWITCH CASE

            //Console.WriteLine("Haftanın gün sayısını:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1: // if(sayi==1)
            //        Console.WriteLine("Pazartesi");
            //        break;

            //    case 2:
            //        Console.WriteLine("Salı");
            //        break; // if deki gibi {} tanımı olmadığı için kapsamı break ile bitiyorsunuz 

            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;

            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;

            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;

            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;

            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default: //else 
            //        Console.WriteLine("Haftanın gün bilgisi Hatalı!!");
            //        break;
            //}


            #region  Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("1.sayı:");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2.sayı:");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İşlem Seçiniz(+,-,*,/):");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "+":
            //        Console.WriteLine(sayi1+sayi2);
            //        break;
            //    case "-":
            //        Console.WriteLine(sayi1 - sayi2);
            //        break;
            //    case "*":
            //        Console.WriteLine(sayi1 * sayi2);
            //        break;
            //    case "/":
            //        Console.WriteLine(sayi1 / sayi2);
            //        break;


            //    default:
            //        Console.WriteLine("Hatalı İşlem Seçimi!!");
            //        break;
            //}

            #endregion
            #region   
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
            ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, 
                yaş 60'ın altında ise çalıştığı gün sayısına göre 
                    eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
                    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
                yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
                yaş 58'ın altında ise çalıştığı gün sayısına göre 
                    eğer 3600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 
                    3600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */

            Console.WriteLine("Cinsiyet:");
            string cins = Console.ReadLine();

            if(cins=="erkek")
            {
                Console.WriteLine("Yaş:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maaş:");
                double maas = Convert.ToDouble(Console.ReadLine());

                if (yas >= 60)
                {
                    Console.WriteLine("İkramiye:"+(maas*10));
                }
                else
                {
                    Console.WriteLine("Prim Günü:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim >= 6000)
                    {
                        Console.WriteLine("İkramiye:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal...");
                    }
                }

            }
            else if (cins == "kadın")
            {
                Console.WriteLine("Yaş:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maaş:");
                double maas = Convert.ToDouble(Console.ReadLine());

                if (yas >= 58)
                {
                    Console.WriteLine("İkramiye:" + (maas * 10));
                }
                else
                {
                    Console.WriteLine("Prim Günü:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim >= 3600)
                    {
                        Console.WriteLine("İkramiye:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal...");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Cinsiyet Bilgisi!");
            }



            #endregion
            #endregion
        }
    }
}
