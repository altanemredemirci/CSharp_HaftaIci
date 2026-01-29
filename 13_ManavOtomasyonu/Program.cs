using System.Collections;

namespace _13_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList halMeyve = new ArrayList(){"ELMA","ARMUT","MUZ"};
            ArrayList halSebze = new ArrayList(){"DOMATES","BIBER","PATLICAN"};

            ArrayList manavMeyve = new ArrayList();
            ArrayList manavSebze = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();

            ArrayList musteri = new ArrayList();

            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M Sebze için S Çıkış için Ç seçiniz:");
                string halSecim = Console.ReadLine().ToUpper();

                if (halSecim == "M") 
                {
                    ListeYazdir(halMeyve);

                    Console.WriteLine("Ürün Numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if(urunNo>=halMeyve.Count || urunNo < 0)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (!manavMeyve.Contains(halMeyve[urunNo])) //manavMeyve.Contains(halMeyve[urunNo]==false
                        {
                            manavMeyve.Add(halMeyve[urunNo]);
                            manavMeyveKilo.Add(kilo);
                        }
                        else
                        {
                            int index = manavMeyve.IndexOf(halMeyve[urunNo]);
                            manavMeyveKilo[index] = (int)manavMeyveKilo[index] + kilo;
                        }
                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap != "E")
                        {
                            Console.WriteLine("Yine Bekleriz..");
                            break;
                        }
                    }
                }
                else if (halSecim == "S") 
                {
                    Console.WriteLine("Ürün Numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= halSebze.Count || urunNo < 0)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }
                    else
                    {
                        Console.WriteLine("Kaç kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if (!manavSebze.Contains(halSebze[urunNo]))
                        {
                            manavSebze.Add(halSebze[urunNo]);
                            manavSebzeKilo.Add(kilo);
                        }
                        else
                        {
                            int index = manavSebze.IndexOf(halSebze[urunNo]);
                            manavSebzeKilo[index] = (int)manavSebzeKilo[index] + kilo;
                        }
                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap != "E")
                        {
                            Console.WriteLine("Yine Bekleriz..");
                            break;
                        }
                    }
                }
                else if (halSecim == "Ç") 
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break; 
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                }
            }
            while (true)
            {
                Console.WriteLine("MANAVA HOŞGELDİNİZ");
                Console.WriteLine("Meyve için M Sebze için S Çıkış için Ç seçiniz:");
                string manavSecim = Console.ReadLine().ToUpper();

                if (manavSecim == "M") 
                {
                    ListeYazdir(manavMeyve);
                    Console.WriteLine("Ürün Numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= manavMeyve.Count || urunNo < 0)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }

                    if (manavMeyve.Contains(manavMeyve[urunNo]))
                    {
                        Console.WriteLine("Kaç kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if ((int)manavMeyveKilo[urunNo] >= kilo)
                        {
                            musteri.Add(manavMeyve[urunNo]);
                            manavMeyveKilo[urunNo] = (int)manavMeyveKilo[urunNo] - kilo;

                            if ((int)manavMeyveKilo[urunNo] == 0)
                            {
                                manavMeyve.RemoveAt(urunNo);
                                manavMeyveKilo.RemoveAt(urunNo);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }

                    Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap != "E")
                    {
                        Console.WriteLine("Yine Bekleriz..");
                        break;
                    }



                }
                else if (manavSecim == "S") 
                {
                    ListeYazdir(manavSebze);
                    Console.WriteLine("Ürün Numarası:");
                    int urunNo = Convert.ToInt32(Console.ReadLine());

                    if (urunNo >= manavSebze.Count || urunNo < 0)
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }

                    if (manavSebze.Contains(manavSebze[urunNo]))
                    {
                        Console.WriteLine("Kaç kilo?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if ((int)manavSebzeKilo[urunNo] >= kilo)
                        {
                            musteri.Add(manavSebze[urunNo]);
                            manavSebzeKilo[urunNo] = (int)manavSebzeKilo[urunNo] - kilo;

                            if ((int)manavSebzeKilo[urunNo] == 0)
                            {
                                manavSebze.RemoveAt(urunNo);
                                manavSebzeKilo.RemoveAt(urunNo);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Seçimi!");
                    }

                    Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap != "E")
                    {
                        Console.WriteLine("Yine Bekleriz..");
                        break;
                    }



                }
                else if (manavSecim == "Ç")
                {
                    Console.WriteLine("Yine Bekleriz..");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!");
                }
            }

            ListeYazdir(musteri);


        }

        static void ListeYazdir(ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"{i}-{array[i]}");
            }           
        }

        static void UrunSatis()
        {

        }
    }
}
