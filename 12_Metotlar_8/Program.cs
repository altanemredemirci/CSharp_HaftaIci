namespace _12_Metotlar_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD METOTLAR - AŞIRI YÜKLENMİŞ METOT
            // Aynı isimle yazılmış ama metot imzaları farklı olan metotlara denir.
            // Metot İmzası: Parametre sayısı, Parametre veri tipi

            //Toplama();
            //Toplama(11, 12);
            //Toplama(11, 11.5);
            //Toplama(11.7, 11);


            //DEFAULT DEĞER
            //Bir metoda parametrenin tanımlı olması ama çağrılırken gönderilmemesi durumunda alacağı değeri tanımlar

            //DegerAl(10, 20);
            //DegerAl(10);


            //OUT KEYWORD
            //Parametre olarak gönderilen değişkenin metot içinde manipule olmasını sağlar. Bu sayede metot dışarıdan(out) gelen değeri değiştirebilir.
            // ** out kullanılacak değişkene ilk tanımlama da değer verilmek zorunda değildir. Çünkü metot içinde mutlaka yeni değer alacaktır.

            //string isim;

            //EkranaYaz(out isim);

            //Console.WriteLine("Sayı giriniz:");
            //string s = Console.ReadLine();
            //int sayi;

            //int.TryParse(s, out sayi);

            //Console.WriteLine(sayi);


            //REF KEYWORD
            //Parametre olarak gönderilen değişkenin metot içinde manipule olmasını sağlar. Bu sayede metot dışarıdan referans(ref) gelen değeri değiştirebilir.

            // ** ref kullanılacak değişkene ilk tanımlama da değer verilmesi zorunludur.. Çünkü metot içinde yeni değer almayabilir.

            //int sayi=10;

            //EkranYaz(ref sayi);

            //PARAMS KEYWORD
            //Params anahtar kelimesi, bir methoda değişken argümanın aynı tipte geçirilmesine olanak tanır.
            //params parametresi, metodun son parametresi olarak tanımlanmalıdır ve yalnızca bir params anahtar kelimesi kullanılabilir.
            //params ile belirtilen parametre bir dizi olarak işlenir, bu da metod içinde bir dizi erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir.


            DiziYazdir(1, 2, 3, 4, 5, 6);
            DiziYazdir(7,8,9);


        }

        #region OVERLOAD METHODS
        static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi2 + sayi1);
        }



        static void Toplama(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Toplama(int s1, int s2, int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }

        static void Toplama(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }

        static void Toplama(double s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }
        #endregion

        #region DEFAULT DEĞER
            static void DegerAl(int s1, int s2 = 5)
            {
                Console.WriteLine(s1 + s2);
            }
        #endregion

        #region OUT KEYWORD
        
        static void EkranaYaz(out string ad)
        {
            ad = "Uras Demirci";
            Console.WriteLine(ad);
        }
        #endregion

        #region REF KEYWORD

        static void EkranYaz(ref int sayi)
        {
            Console.WriteLine(sayi+5);
        }
        #endregion

        #region PARAMS

        static void DiziYazdir(params int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        #endregion
    }
}
