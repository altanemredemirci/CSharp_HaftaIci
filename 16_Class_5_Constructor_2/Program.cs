namespace _16_Class_5_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uye uye = new Uye();

            Uye uye2 = new Uye("altanemre","1");

        }
    }

    class Uye
    {
        internal string KullaniciAdi;
        internal string Sifre;

        public Uye()
        {
            Console.WriteLine("Kullaniciadi:");
            KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifre:");
            Sifre = Console.ReadLine();
        }

        public Uye(string username,string password)
        {
            KullaniciAdi = username;
            Sifre = password;
        }
    }
}
