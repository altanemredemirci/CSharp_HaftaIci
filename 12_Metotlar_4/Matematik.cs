using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Metotlar_4
{
    public class Matematik
    {
        public static void Toplama()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 + s2);
        }


        internal static void Cikarma()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 - s2);

            Carpma();
        }

        private static void Carpma()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 * s2);
        }
    }
}
