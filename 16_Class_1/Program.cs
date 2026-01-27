namespace _16_Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(); //Instance - Örneklem 
            ogrenci.Ad = "Altan Emre";
            ogrenci.Soyad = "Demirci";
            ogrenci.Numara = 1;


            Ogrenci ogrenci2 = new Ogrenci(); //Instance - Örneklem 
            ogrenci2.Ad = "İbrahim Halil";
            ogrenci2.Soyad = "Demirci";
            ogrenci2.Numara = 2;

            //Listenin tutacağı veri tipini class olarak tanımlayabilirim.
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            //ogrenciler.Add(ogrenci);
            //ogrenciler.Add(ogrenci2);

            Ogrenci.Kayit(ogrenciler);
            Ogrenci.Kayit(ogrenciler);
            Ogrenci.Kayit(ogrenciler);


            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
            }
        }
    }

    //class tanımları default olarak internal tipinde erişime sahiptir.
    class Ogrenci
    {
        //sınıfa ait property
        internal int Numara; //default olarak class a özel tanımlardır. yani private tanımlıdır.
        internal string Ad;
        internal string Soyad;

        internal static void Kayit(List<Ogrenci> liste)
        {
            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();

            Console.WriteLine("Numara:");
            ogrenci.Numara = Convert.ToInt32(Console.ReadLine());

            liste.Add(ogrenci);
        }

    }
}
