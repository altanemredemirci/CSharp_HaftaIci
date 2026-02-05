namespace _16_Class_6_Enum
{

    enum Gunler
    {
        Pazartesi = 2,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum Markalar
    {
        BMW,
        Mercedes,
        Ford
    }

    internal class Program
    {
        //Enum: Bir özel veri tipidir ve sabit değerler kümesini temsil eder.
       

        static void Main(string[] args)
        {
            string Ad = "Emre";
            int Yas = 45;
            Gunler gun = Gunler.Çarşamba;

            Araba araba = new Araba();
            araba.Marka = Markalar.BMW;
            araba.Plaka = "34YN297";
            araba.Fiyat = 750000;


        }
    }

    class Araba
    {
        public string Plaka;
        public double Fiyat;
        public Markalar Marka;
    }
}
