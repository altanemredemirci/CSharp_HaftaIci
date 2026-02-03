namespace _16_Class_5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR METHOD - YAPICI(KURUCU) METOT
            /*
             Bir sınıftan bir nesne oluşturulduğunda otomatik çalışan gizli metoddur. 
             Bulunduğu class ile aynı isme sahiptir.
             Herhangi bir void veya return değer almaz.
             Nesne oluşturulduğu an otomatik çalışır ve tanımlanan işlemi gerçekleştirir.
             */
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            Ogrenci ogrenci = new Ogrenci(ogrencis);

        }
    }

    class Ogrenci
    {
        //sınıfa ait property
        internal int Numara; //default olarak class a özel tanımlardır. yani private tanımlıdır.
        internal string Ad;
        internal string Soyad;

        public Ogrenci(List<Ogrenci> ogrencis)
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();

            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());

        }


    }
}
