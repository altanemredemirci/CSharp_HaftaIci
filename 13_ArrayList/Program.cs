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
            //foreach (var item in arrayList)
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

            //ArrayList arrayList = new ArrayList() { 11, 23, 34, 45,56,7,8,9,0 };

            //Console.WriteLine("Eleman Sayısı:"+arrayList.Count); //Eleman Sayısı

            //Console.WriteLine("ArrayList Kapasitesi:"+arrayList.Capacity); //ArrayList Kapasitesi


            //*** CLEAR()

            ArrayList arrayList = new ArrayList() { 11, 23, 34, 45, 56, 7, 8, 9, 0 };

            arrayList.Clear();//bütün değerleri siler.

        }
    }
}
