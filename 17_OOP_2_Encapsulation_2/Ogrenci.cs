using System;
using System.Collections.Generic;
using System.Text;

namespace _17_OOP_2_Encapsulation_2
{
    internal class Ogrenci
    {
        private double vize;
        private double final;

        public void Ortalama()
        {
            double ortalama = vize * 0.4 + final * 0.6;

            Console.WriteLine("Ortalama:"+ortalama);
        }


        public double _vize
        {
            get { return vize; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    vize = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Vize not aralığı 0-100 arasında olmalıdır.");
                        Console.WriteLine("Vize:");
                        _vize = Convert.ToDouble(Console.ReadLine());
                        if (_vize >= 0 && _vize <= 100)
                        {
                            vize = _vize;
                            break;
                        }
                    }
                }
            }
        }
        public double _final
        {
            get { return final; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    final = value;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("final not aralığı 0-100 arasında olmalıdır.");
                        Console.WriteLine("final:");
                        _final = Convert.ToDouble(Console.ReadLine());
                        if (_final >= 0 && _final <= 100)
                        {
                            final = _final;
                            break;
                        }
                    }
                }
            }
        }
    }
}
