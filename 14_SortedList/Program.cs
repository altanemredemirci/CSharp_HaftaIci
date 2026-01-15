using System.Collections;

namespace _14_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList: Key:Value mantığı ile çalışır. Sözlük gibi kullanımı vardır. Key üzerinden valur değerine erişilebilir ve aynı sözlük gibi A-Z ye sıralıdır.
            //SortedList<key,value>

            SortedList sozluk = new SortedList()
            {
                {"Bugün","Today"},
                {"Yarın","Tomorrow" },
                {"Hava","Weather" },
                {"Gökyüzü","Sky" },
                {"Karlı","Snowy" },
                {"Güneşli","Sunny" },
                {"Bulutlu","Cloudy" },
                {"Açık","Clear" },
                {"Kapalı","Cloudy" },
                //{"Üç",3 },
                //{4,"Four" }
            };

            //Console.WriteLine(sozluk["Bugün"]); //Anahtar değer üzerinden çalışır.
            //Console.WriteLine(sozluk["Today"]); //Today diye bir key değer olmadığı için boş döner.


            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}


            // Eleman Ekleme
            sozluk.Add("Yağmur", "Rain");         

            sozluk["Siyah"] = "Black"; //Varsa günceller, yoksa ekler.
            sozluk["Siyah"] = "DarkBlack";

            foreach (DictionaryEntry item in sozluk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
