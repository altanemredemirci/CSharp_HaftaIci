namespace _16_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uye Sistemi Geliştiriniz:
            //Username,FullName,Email,Password

            List<Uye> uyes = new List<Uye>();

            Uye.Kayit(uyes);
        }
    }

    class Uye
    {
        internal string Username;
        internal string Fullname;
        internal string Email;
        internal string Password;

        public static void Kayit(List<Uye> liste)
        {
            Uye kullanici = new Uye();

            Console.WriteLine("Username:");
            kullanici.Username = Console.ReadLine();
            Console.WriteLine("Fullname:");
            kullanici.Fullname = Console.ReadLine();
            Console.WriteLine("Email:");
            kullanici.Email = Console.ReadLine();
            Console.WriteLine("Password:");
            kullanici.Password = Console.ReadLine();

            liste.Add(kullanici);

        }
    }
}
