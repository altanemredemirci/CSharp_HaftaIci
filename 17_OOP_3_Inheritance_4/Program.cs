namespace _17_OOP_3_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  Şirket Otomasyonu Projesi
                 IK:Id,Name,Surname,TC,PersonelSayisi,Kaydet()
                 IT:Id,Name,Surname,TC,ProgramSayisi,Kaydet()
                 MUH:Id,Name,Surname,TC,HesapSayisi,Kaydet()
                  */
            //Ortak (base) classta tanımlanan bir metot birden fazla class miras alındığında işe yarıyor. ama bu classların dışında farklı bir özelliğe sahip bir class daha miras alırsa ve yazılan metot işe yaramaz ise "new" keyword ü ile o classa özel yeniden metot tanımlanır. 


            IK ik = new IK();
            ik.Kaydet();

        }
    }

    class Personel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }

        //public void Kaydet()
        //{
        //    Console.WriteLine("Id:");
        //    Id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Name:");
        //    Name = Console.ReadLine();
        //    Console.WriteLine("Surname:");
        //    Surname = Console.ReadLine();
        //    Console.WriteLine("TC:");
        //    TC = Console.ReadLine();
        //}
    }


    class IK : Personel 
    {
        public int PersonelSayisi { get; set; }

        //NameHiding: Miras alınan bir sınıfa base classtan aktarılan bir özellik yok sayılıyor.
        public void Kaydet()
        {
            Console.WriteLine("Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            Surname = Console.ReadLine();
            Console.WriteLine("TC:");
            TC = Console.ReadLine();
            Console.WriteLine("Personel Sayisi:");
            PersonelSayisi = Convert.ToInt32(Console.ReadLine());

        }

    }

    class IT : Personel
    {
        public int ProgramSayisi { get; set; }
    }

    class MUH : Personel
    {
        public int HesapSayisi { get; set; }
    }

}
