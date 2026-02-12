using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_3_Inheritance_3
{
    internal class C:B
    {
        public int c { get; set; }

        public C()
        {
            Console.WriteLine("Ben C sınıfının kurucu metoduyum");
        }
    }
}
