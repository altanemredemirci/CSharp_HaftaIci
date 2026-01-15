using System.Collections;

namespace _13_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array: Sabit veri tipi ve sabit uzunluk
            //int[] sayilar = new int[10];

            //ArrayList: Veri tipi kısıtlaması yok. Uzunluk kısıtlaması yok.
            //ArrayList ler using System.Collections; üzerinden referans alınarak kullanılırlar.

            //ArrayList arrayList = new ArrayList(); //Boş Arraylist Tanımı

            //ArrayList Eleman Ekleme
            //arrayList.Add("Altan"); //string
            //arrayList.Add('E'); //char
            //arrayList.Add(19); //int
            //arrayList.Add(19.5); //double
            //arrayList.Add(14.5f); //float
            //arrayList.Add(14.5m); //decimal


            //ArrayList arrayList2 = new ArrayList() { 11, 23, 34, "Altan" }; //Dolu ArrayList Tanımı


            //ArrayList Ekrana Yazdırma
            //var:variable anlamına gelir. Bütün veri tiplerini kapsar. 
            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arrayList2[2]);

            //arrayList2[2] = 44;
            //Console.WriteLine(arrayList2[2]);

            //Olmayan Index değerine eleman eklenemez.
            //arrayList2[4] = 45;

            //Console.WriteLine(arrayList2[2]);


            //Kullanıcıdan alınacak 5 değeri arrayListe ekleterek ekrana yazdırınız?

            //ArrayList sayilar = new ArrayList();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    sayilar.Add(sayi);
            //}

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            //İstenilen Index değerine Eleman Ekleme
            //ArrayList arrayList = new ArrayList() { 11, 23, 34, "Altan" };

            //arrayList.Insert(2, 45);


            //*** COUNT ve CAPACITY

            //ArrayList arrayList = new ArrayList() { 11, 23, 34, 45,1 };

            //Console.WriteLine("Eleman Sayısı:"+arrayList.Count); //Eleman Sayısı

            //Console.WriteLine("ArrayList Kapasitesi:"+arrayList.Capacity); //ArrayList Kapasitesi


            //*** CLEAR()

            //ArrayList arrayList = new ArrayList() { 11, 23, 34, 45, 56, 7, 8, 9, 0 };

            //arrayList.Clear();//bütün değerleri siler.

            #region Kullanıcıdan aile birey sayısını öğrenin daha sonra aile birey isimlerini alarak arrayliste atın ve ekrana yazdırınız.

            //ArrayList aile = new ArrayList();

            //Console.WriteLine("Kaç kişiyiz?");
            //int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < kisiSayisi; i++)
            //{
            //    Console.WriteLine("Aile Birey Adı:");
            //    string ad = Console.ReadLine();

            //    aile.Add(ad);
            //}

            //foreach (string item in aile)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            //ArrayList arrayList = new ArrayList() { "İstanbul", "Ankara", "Çanakkale", "Kars", "Balıkesir", "Kastamonu" };

            //arrayList.Remove("Ankara");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}



            //arrayList.Sort();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Reverse();

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.RemoveAt(2);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}



            //ArrayList arrayList = new ArrayList() { "İstanbul", "Ankara", "Çanakkale", "Kars", "Balıkesir", "Kastamonu" };

            //ArrayList arrayList2 = arrayList;

            //ArrayList arrayList2 = (ArrayList)arrayList.Clone();

            //arrayList.Add("İzmir");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("----------------");

            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}




            //ArrayList arrayList = new ArrayList() { "İstanbul", "Ankara", "Çanakkale", "Kars", "Balıkesir", "Kastamonu" };

            //ArrayList arrayList2 = new ArrayList() { 1, 2, 3 };

            //arrayList2.AddRange(arrayList);

            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}


            //Varlık Kontrolü Yapar.
            //if (arrayList.Contains("ankara")) 
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yok");
            //}


            //Değerin Index numarasını verir.
            //int index = arrayList.IndexOf("Ankara");
            //Console.WriteLine(index);


            #region Kullanıcıdan sayı istenilecek girilen değer sayı ise bir arraylist e atılacak. Girilen değer sayı değilde 'çık' ifadesi olursa arraylist toplanarak ekrana sonuç yazılacak

            ArrayList arrayList = new ArrayList();

            while (true)
            {
                Console.WriteLine("Sayı giriniz:");
                string deger = Console.ReadLine();
                int sayi;

                if (deger == "çık")
                {
                    break;
                }
                else if(int.TryParse(deger,out sayi))
                {
                    arrayList.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Hatalı Değer Girişi");
                }
            }
            int toplam = 0;
            foreach (int item in arrayList)
            {
                toplam += item;
            }

            Console.WriteLine("Toplam:"+toplam);
            #endregion

        }
    }
}
