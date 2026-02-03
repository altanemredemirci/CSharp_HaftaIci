using System.Collections;

namespace _15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En popüler kullanılan koleksiyon tipi LIST dir.

            //Array avantajı belirli bir veri tipinde data tutması.
            //Dezavantajı ise mutlaka bir uzunluk verilmek zorunda olması
            int[] array = new int[10];


            //Avantajı belirli bir uzunluk verilmek zorunda değildi.
            //Dezavantajı belirli bir veri tipine bağlım değildi.
            ArrayList arrayList = new ArrayList();


            //List hem belirli bir veri tipinde data tutan, hem de uzunluk sınırı olmayan koleksiyon tipidir.

            //Boş bir liste tanımı 
            List<string> isimler = new List<string>();

            //Dolu List Tanımı
            List<string> adlar = new List<string>() { "Altan", "Can", "Ahmet", "Ceren" };

            adlar.Add("İbrahim");
            adlar.Add("Ali");

            //foreach (string item in adlar)
            //{
            //    Console.WriteLine(item);
            //}


            List<int> notlar = new List<int>() { 11, 22, 33 };

            List<int> notlar2 = new List<int>() { 44, 55, 66 };

            notlar2.AddRange(notlar);


            foreach (int item in notlar2)
            {
                Console.WriteLine(item);
            }

            notlar2.Remove(55);

            notlar2.RemoveAt(1);
            Console.WriteLine("-----------");
            foreach (int item in notlar2)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
