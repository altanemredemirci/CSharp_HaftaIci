using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Metotlar_3
{
    internal class DortIslem
    {
        internal static void Toplama()
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
        }

        internal static void Carpma()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 * s2);
        }

        internal static void Bolme()
        {
            Console.WriteLine("1.Sayı Gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayı Gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s1 / s2);
        }
    }
}
