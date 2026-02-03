namespace _16_Class_5_Constructor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Private constructor metot, class dışında nesne oluşturulmasına izin vermez.Sadece tanımlı olduğu class içinde nesne oluşturulabilir.
            //Uye uye = new Uye();
        }
    }

    class Uye
    {
        internal string KullaniciAdi;
        internal string Sifre;

        private Uye()
        {
                
        }

        public static void Kayit()
        {
            Uye uye = new Uye();
            Console.WriteLine("Kullaniciadi:");
            uye.KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre:");
            uye.Sifre = Console.ReadLine();
        } 
    }
}
