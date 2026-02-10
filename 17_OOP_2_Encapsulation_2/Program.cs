namespace _17_OOP_2_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Üniversite sınav sonuçlarının  vize ve final property leri ile alındığı  vize'nin %40 final'ın %60 ile ortalamayı hesaplayan bir metot tanımlayınız.
            //vize ve final notlarının 0-100 aralığında olmasına dikkat ediniz.

            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Final:");
            ogrenci._final = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vize:");
            ogrenci._vize = Convert.ToDouble(Console.ReadLine());

            ogrenci.Ortalama();
        }
    }

}
