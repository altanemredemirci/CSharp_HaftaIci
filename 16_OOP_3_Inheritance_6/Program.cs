namespace _17_OOP_3_Inheritance_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         OKUL YÖNETİM SİSTEMİ
         Öğrenci:Ad,Numara,TC,Adres,Telefon,Sınıf
         Öğretmen:Ad,TC,Adres,Telefon,Branş
         Müdür:Ad,TC,Adres,Telefon,Branş,KıdemYili
         Veli:Ad,TC,Adres,Telefon,ÇocukSayısı

         Kaydet(): Bir listeye kayıt yapalım 
         */

            //base kelimesi miras alınan sınıfı temsil eder.


            Mudur mudur = new Mudur();
            mudur.Kaydet();

        }
    }
    class Vatandas
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }

        public void Kaydet()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Adres:");
            Adres = Console.ReadLine();
            Console.WriteLine("TC:");
            TC = Console.ReadLine();
            Console.WriteLine("Telefon:");
            Telefon = Console.ReadLine();
        }
    }

    class Ogrenci:Vatandas
    {
        public int Numara { get; set; }
        public string Sinif { get; set; }

        public new void Kaydet()
        {
            base.Kaydet();

            Console.WriteLine("Numara:");
            Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sınıf:");
            Sinif = Console.ReadLine();
        }
        
    }

    class Ogretmen : Vatandas
    {
        public string Brans { get; set; }
        public new void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Branş:");
            Brans = Console.ReadLine();
        }
       
    }

    class Mudur : Ogretmen
    {
        public int KidemYili { get; set; }
        public new void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Kıdem Yılı:");
            KidemYili = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Veli : Vatandas
    {
        public int CocukSayisi { get; set; }

        public new void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Çocuk Sayısı:");
            CocukSayisi = Convert.ToInt32(Console.ReadLine());
        }
    }
}
