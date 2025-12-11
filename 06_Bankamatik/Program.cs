namespace _06_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region BANKAMATİK
            /*   
    //             *   25000 tl parası olacak 
    //            Bir bankamatik düşünülerek tasarlanacak bir program  için 
    //            Kartlı işlem    1
    //            Kartsız işlem   2
    //            //********Kartlı işlem bölümü
    //            Şifre istenecek=> Şifre:ab18
    //            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
    //            //*******************Ana Menü 
    //            Para Çekmek için    1
    //            Para yatırmak için  2
    //            Para Transferleri   3
    //            Eğitim Ödemeleri    4
    //            Ödemeler            5
    //            Bilgi Güncelleme    6
    //            //*********************Seçim 1************
    //            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
    //            Ana meüye dönmek için   9
    //            Çıkmak için             0
    //            //******************Seçim 2***********************
    //            Kredi Kartına   1
    //            Kendi Hesabınıza yatırmak için  2
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //------------------------------------
    //            //----1
    //            Kredi kardı için en az 12 haneli kart numarasını girsin
    //            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //--------------------------
    //            //---2
    //            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //*****************************Seçim 3
    //            Başka Hesaba EFT    1
    //            Başka Hesaba Havale 2
    //            //---------------------------------
    //            //--1
    //            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
    //            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //-----------------------------
    //            //---2
    //            hesap için 11 haneli hesap numarası işlemler doğru ise
    //            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //****************Seçim 4
    //            Eğitim Ödemeleri sayfası arızalı
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //****************************Seçim 5
    //            Elektrik Faturası       1
    //            Telefon Faturası        2
    //            İnternet faturası       3
    //            Su Faturası             4
    //            OGS Ödemeleri           5
    //            //-----------------------------------------
    //            //---1 => bütün faturala için aşağıdaki şart yeterli
    //            fatura tutarı istenir, hesap uygun ise yatırılır değilse
    //            Ana Menü        9
    //            Çıkmak için     0
    //            //-----------------------------------
    //            //***************Seçim 6
    //            Şifre değiştirmek için 1
    //            Şifre değiştirme işlemi gerçekleştirilir
    //            Ana Menü        9
    //            Çıkmak için     0
    */


            #endregion

            while (true)
            {
                Console.WriteLine("Kartlı İşlem-1\nKartsız İşlem-2\nÇıkış-3");
                int kartSecim = Convert.ToInt32(Console.ReadLine());

                if (kartSecim == 1) 
                {
                    string sifre = "ab18";
                    double bakiye = 25000;
                    int hak = 3;
                    while (hak > 0)
                    {
                        Console.WriteLine("Şifre:");
                        string sfr = Console.ReadLine();
                        hak--;

                        if (sifre == sfr) 
                        {
                            hak = 0;
                            while (true)
                            {
                                Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Para Transferi\n4-Eğitim Ödemeleri\n5-Faturalar\n6-Bilgi Güncelle\n7-Çıkış\nSeçiminiz:");
                                int anaMenu = Convert.ToInt32(Console.ReadLine());

                                if (anaMenu == 1)
                                {
                                    Console.WriteLine("Çekilecek Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Paranızı Alınız. Yeni Bakiye:"+bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye!");
                                    }
                                }
                                else if (anaMenu == 2) 
                                {
                                    Console.WriteLine("Hesaba-1\nKredi Kartı-2\nSeçiminiz:");
                                    string yatirma = Console.ReadLine();
                                    if (yatirma == "1") 
                                    {
                                        Console.WriteLine("Yatırılacak miktar:");
                                        int miktar = Convert.ToInt32(Console.ReadLine());

                                        bakiye += miktar;

                                        Console.WriteLine("Para Yatırıldı. Yeni Bakiaye:"+bakiye);
                                    }
                                    else if (yatirma == "2") 
                                    {
                                        Console.WriteLine("16 haneli kart numarası:");
                                        string kartNo = Console.ReadLine();

                                        if (kartNo.Length == 16) //"123212312"
                                        {
                                            long numara;
                                            if(long.TryParse(kartNo,out numara))
                                            {
                                                Console.WriteLine("Yatırılacak miktar:");
                                                int miktar = Convert.ToInt32(Console.ReadLine());

                                                if (bakiye >= miktar)
                                                {
                                                    bakiye -= miktar;
                                                    Console.WriteLine("Para Yatırıldı. Yeni Bakiye:"+bakiye);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz Bakiye!");
                                                }

                                            }
                                            else 
                                            {
                                                Console.WriteLine("Kredi kartı numarası rakamlardan oluşmalıdır.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kart numarası 16 haneli olmalıdır!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Seçim!!");
                                    }

                                }
                                else if (anaMenu == 3) 
                                {
                                    Console.WriteLine("EFT-1\nHavale-2\nSeçiminiz:");
                                    string transfer = Console.ReadLine();

                                    if (transfer == "1") 
                                    {
                                        Console.WriteLine("Iban:");
                                        string iban = Console.ReadLine().ToUpper(); //TR1234567890

                                        string IbanNo = iban.Substring(2);

                                        if(iban.StartsWith("TR") && long.TryParse(IbanNo,out _) && iban.Length==14)
                                        {
                                            Console.WriteLine("Transfer edilecek miktar:");
                                            int miktar = Convert.ToInt32(Console.ReadLine());

                                            if (bakiye >= miktar)
                                            {
                                                bakiye -= miktar;
                                                Console.WriteLine("Para Gönderildi. Yeni Bakiye:" + bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz Bakiye!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Başında TR olacak şekilde 12 rakam dizisindne oluşan bir IBAN numarası giriniz");
                                        }

                                    }
                                    else if (transfer == "2") 
                                    {
                                        Console.WriteLine("Hesap Numarası:");
                                        string hesapNo = Console.ReadLine().ToUpper(); //TR1234567890

                                        if (long.TryParse(hesapNo, out _) && hesapNo.Length == 11)
                                        {
                                            Console.WriteLine("Transfer edilecek miktar:");
                                            int miktar = Convert.ToInt32(Console.ReadLine());

                                            if (bakiye >= miktar)
                                            {
                                                bakiye -= miktar;
                                                Console.WriteLine("Para Gönderildi. Yeni Bakiye:" + bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz Bakiye!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Başında TR olacak şekilde 12 rakam dizisindne oluşan bir IBAN numarası giriniz");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama!!");
                                    }

                                }
                                else if (anaMenu == 4) { Console.WriteLine("Eğitim ödemeleri bölümü arızalı!!"); }
                                else if (anaMenu == 5) 
                                { 
                                    
                                }
                                else if (anaMenu == 6) 
                                {
                                    Console.WriteLine("Mevcut Şifre:");
                                    string mevcutSfr = Console.ReadLine();

                                    if (sifre == mevcutSfr) 
                                    {
                                        Console.WriteLine("Yeni şifre:");
                                        string newPass = Console.ReadLine();
                                        Console.WriteLine("Tekrar Yeni şifre:");
                                        string newPass2 = Console.ReadLine();

                                        if (newPass == newPass2)
                                        {
                                            sifre = newPass;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Girilen şifreler uyuşmuyor!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Girilen Şifre Hatalı!");
                                    }
                                }
                                else if (anaMenu == 7) 
                                {
                                    Console.WriteLine("Kartlı İşleme Yönlendiriliyorsunuz...");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Anamenü Seçimi!!");
                                }

                                Console.WriteLine("Anamenü-9\nÇıkış-0");
                                string cevap = Console.ReadLine();
                                if (cevap != "9")
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                           



                        }
                        else if (hak == 0)
                        {
                            Console.WriteLine("Hakkınız Bitti");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Şifre");

                        }


                    }

                
                }
                else if (kartSecim == 2) { }
                else if (kartSecim == 3) { break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }
           


        }
    }
}
