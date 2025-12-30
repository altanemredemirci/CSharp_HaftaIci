namespace _12_Metotlar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DATA ACCESS MODIFIER - Erişim Belirteçleri
            /*  
             *  Tanımlara erişim özelliği atamak.
             *  
             public:Solution içerisinde erişilebilir.
             internal: Sadece tanımlı olduğu proje içerisinde erişilebilir.
             private: Sadece tanımlı class içeriside erişilebilir.
             protected: Tanımlı olduğu class ve miras olarak alınan classlarda erişilebilir.
             */


            //Kullanıcıdan alınan aralıkta, kullanıcının belirlediği kadar rastgele sayıyı bir diziye atayan metodu yazınız.

            //Diziler.Doldur(); //Static

            //Classtan nesne oluşturularak metota erişilebildi.
            //Diziler diziler = new Diziler();
            //diziler.Doldur2();


            //Rastegele 1-100 aralığında 15 sayı tutan ve bu sayıları tekler ve çiftler adında iki ayrı diziye atayan metot.

            //Diziler.TekCiftKontrol();


            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            Indirim();
        }

        static void Indirim()
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

            Console.WriteLine("3.ürün ister misiniz?E/H");
            string cevap = Console.ReadLine();
            if (cevap == "E")
            {
                Indirim3(fiyat1,fiyat2);
            }
            else
            {
                Console.WriteLine("Ödemeniz:"+(fiyat1+fiyat2));
            }

        }

        static void Indirim3(double fiyat1, double fiyat2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double fiyat3 = Convert.ToDouble(Console.ReadLine());

            double toplam = fiyat1 + fiyat2 + (fiyat3 / 2);
            Console.WriteLine("Ödemeniz:" + toplam);
        }

    }

    
}
