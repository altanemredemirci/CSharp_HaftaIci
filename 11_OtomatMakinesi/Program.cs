using System.ComponentModel;

namespace _11_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] urunler = new string[5];
            //urunler[0] = "Bisküvi";

            string[] urunler = { "Gofret", "Kola", "Fanta", "Bisküvi" };
            double[] fiyatlar = { 15, 40, 40, 35 };

            double gunSonu = 0;


            while (true)
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                }

                Console.WriteLine("Ürün No:");
                int urunNo = Convert.ToInt32(Console.ReadLine());

                if (urunNo >= 0 && urunNo < urunler.Length)
                {
                    Console.WriteLine("Para Yatırınız:");
                    int para = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {
                        if (para >= fiyatlar[urunNo])
                        {
                            Console.WriteLine("Afiyet Olsun.Para Üstü:" + (para - fiyatlar[urunNo]));
                            gunSonu += fiyatlar[urunNo];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("1-Para Ekle\n2-Para İade");
                            int secimBakiye = Convert.ToInt32(Console.ReadLine());

                            if (secimBakiye == 1)
                            {
                                Console.WriteLine("Para Yatır:");
                                para += Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Paranız:"+para);
                                para = 0;
                                break;
                            }
                        }
                    }
                  
                }

                else if (urunNo == 123)
                {
                    Console.WriteLine("1-Yeni Ürün\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Gün Sonu\nSeçiminiz:");
                    int islem = Convert.ToInt32(Console.ReadLine());

                    if (islem == 1) 
                    {
                        Console.WriteLine("Ürün Adı:");
                        string urunAd = Console.ReadLine();
                        Console.WriteLine("Ürün Fiyatı:");
                        double urunFiyat = Convert.ToDouble(Console.ReadLine());

                        Array.Resize(ref urunler, urunler.Length + 1);
                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                        urunler[urunler.Length - 1] = urunAd;
                        fiyatlar[fiyatlar.Length - 1] = urunFiyat;
                        Console.WriteLine("Ürün Eklendi.");
                    }
                    else if (islem == 2) 
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                        }
                        Console.WriteLine("Güncellenecek Ürün No:");
                        int guncellenecekUrunNo = Convert.ToInt32(Console.ReadLine());

                        if (guncellenecekUrunNo >= 0 && guncellenecekUrunNo < urunler.Length)
                        {
                            Console.WriteLine("Yeni Ürün Adı:");
                            string urunAd = Console.ReadLine();
                            Console.WriteLine("Yeni Ürün Fiyatı:");
                            double urunFiyat = Convert.ToDouble(Console.ReadLine());

                            urunler[guncellenecekUrunNo] = urunAd;
                            fiyatlar[guncellenecekUrunNo] = urunFiyat;

                            Console.WriteLine("Ürün Güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Ürün Seçimi!");
                        }
                    }
                    else if (islem == 3) 
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                        }
                        Console.WriteLine("Silinecek Ürün No:");
                        int silinecekUrunNo = Convert.ToInt32(Console.ReadLine());

                        if(silinecekUrunNo>=0 && silinecekUrunNo < urunler.Length)
                        {
                            Array.Clear(urunler, silinecekUrunNo, 1);
                            Array.Clear(fiyatlar, silinecekUrunNo, 1);

                            Console.WriteLine("Ürün Silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Ürün Seçimi!");
                        }
                    }
                    else if (islem == 4) 
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                        }
                    }
                    else if (islem == 5) 
                    {
                        Console.WriteLine("Gün Sonu Tutar:"+gunSonu);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı İşlem!");
                    }

                }

                else
                {
                    Console.WriteLine("Hatalı Ürün Seçimi!");
                }
            }

          
        }
    }
}
