namespace _12_Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 2 sayı bir işlem alarak sayılara işlemi uygulayan ve sonucunu ekrana yazdıran metot.

            //Parametreli Tanım
            //Console.WriteLine("1.Sayı Gir:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("2.Sayı Gir:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("İşlem:");
            //string islem = Console.ReadLine();

            //DortIslem(sayi1, sayi2, islem);



            //Console.WriteLine("1.Sayı Gir:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayı Gir:");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İşlem:");
            //string islem2 = Console.ReadLine();

            //DortIslem(sayi3, sayi4, islem2);



            //DortIslem2();
            //DortIslem2();
            //DortIslem2();

        }

        static void DortIslem(int s1,int s2,string islem)
        {
            if (islem == "+")
            {
                Console.WriteLine(s1+s2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(s1-s2);
            }
            else if(islem == "*")
            {
                Console.WriteLine(s1*s2);
            }
            else if (islem == "/")
            {
                Console.WriteLine(s1/s2);
            }
            else
            {
                Console.WriteLine("İşlem Hatalı");
            }
        } 

        static void DortIslem2()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem:");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine(s1 + s2);
            }
            else if (islem == "-")
            {
                Console.WriteLine(s1 - s2);
            }
            else if (islem == "*")
            {
                Console.WriteLine(s1 * s2);
            }
            else if (islem == "/")
            {
                Console.WriteLine(s1 / s2);
            }
            else
            {
                Console.WriteLine("İşlem Hatalı");
            }
        }

    }
}
