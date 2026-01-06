namespace _12_Metotlar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DEĞER DÖNDÜREN METOTLAR
            // Bir metot gerçekleştirdiği işlem sonucunu return kelimesi ile çağrıldığı yere taşıyor ise değer döndüren metot denir.

            //int sonuc = Toplama();

            //Console.WriteLine("3.sayı:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sonuc+sayi3);


            //SORU: kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            Indirim2();


        }

        static int Toplama()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;

            return toplam;
        }

        static void Indirim2()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat1 > fiyat2)
            {
                fiyat1 = fiyat1 * 0.7;
            }
            else
            {
                fiyat2 = fiyat2 * 0.7;
            }

            double fiyat3 = Indirim3();

            Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2+fiyat3));

        }

        static double Indirim3()
        {
            Console.WriteLine("3.ürün ister misiniz?E/H");
            string cevap = Console.ReadLine();
            if (cevap == "E")
            {
                Console.WriteLine("3.Ürün Fiyatı:");
                double urun3 = Convert.ToDouble(Console.ReadLine());

                return urun3 / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
