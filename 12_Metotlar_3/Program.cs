namespace _12_Metotlar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı bir işlem alarak sayılara işlemi uygulayan ve sonucunu ekrana yazdıran 4 ayrı metot.

            Console.WriteLine("İşlem:");
            string islem = Console.ReadLine();

            if (islem == "+")
                DortIslem.Toplama();
            else if (islem == "-")
                DortIslem.Cikarma();
            else if (islem == "*")
                DortIslem.Carpma();
            else if (islem == "/")
                DortIslem.Bolme();
            else
            {
                Console.WriteLine("Hatalı İşlem!");
            }

        }

        //static void Toplama()
        //{
        //    Console.WriteLine("1.Sayı Gir:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("2.Sayı Gir:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(s1+s2);
        //}

        //static void Cikarma()
        //{
        //    Console.WriteLine("1.Sayı Gir:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("2.Sayı Gir:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(s1 - s2);
        //}

        //static void Carpma()
        //{
        //    Console.WriteLine("1.Sayı Gir:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("2.Sayı Gir:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(s1 * s2);
        //}

        //static void Bolme()
        //{
        //    Console.WriteLine("1.Sayı Gir:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("2.Sayı Gir:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(s1 / s2);
        //}
    }
}
