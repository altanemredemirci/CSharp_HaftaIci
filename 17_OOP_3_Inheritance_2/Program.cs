namespace _17_OOP_3_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir Kolej sisteminde ilkokul,Ortaokul ve lise yer almaktadır.
            //ilkokul:No,Ad,Soyad,Veli Telefon,OkumaYazmaBiliyorMu
            //ortaokul:No,Ad,Soyad,Veli Telefon,Notlar
            //lise:No,Ad,Soyad,Veli Telefon,YKSPuanı

            Ilkokul ilkokul = new Ilkokul();
            ilkokul.OkumaYazma = true;
            ilkokul.Soyad = "Demirci";
            ilkokul.Ad = "Altan Emre";
            ilkokul.No = 10;

            Console.WriteLine(ilkokul.No);
            Console.WriteLine(ilkokul.Ad);
            Console.WriteLine(ilkokul.Soyad);
            Console.WriteLine(ilkokul.OkumaYazma);

        }
    }

    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string VeliTelefon { get; set; }
    }

    class Ilkokul : Ogrenci
    {
        public bool OkumaYazma { get; set; }
    }

    class Ortaokul : Ogrenci
    {
        public int Notlar { get; set; }
    }

    class Lise : Ogrenci
    {
        public int YKSPuan { get; set; }
    }
}
