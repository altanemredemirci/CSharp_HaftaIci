namespace _17_OOP_3_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KALITIM-MİRAS ALMA-INHERITANCE

            //Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlanmasına denir.
            // ** KURAL: Her sınıf tek bir sınıfatan kalıtım alabilir.
            // ** KURAL: Kalıtım alınan sınıfdaki özelliklerin private harici hepsi aktarılır.

            /*
             Şirket Otomasyonu Projesi
            IK:Id,Name,Surname,TC,PersonelSayisi,BilgiYazdır()
            IT:Id,Name,Surname,TC,ProgramSayisi,BilgiYazdır()
            MUH:Id,Name,Surname,TC,HesapSayisi,BilgiYazdır()
             */

            IK ik = new IK();
           
            ik.BilgiYazdir();

            IT it = new IT();
            it.BilgiYazdir();
            
        }
    }

    class Vatandas
    {
        public string TC { get; set; }
    }

    class Personel:Vatandas
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        

        public void BilgiYazdir()
        {
            Console.WriteLine("Bilgiler Yazdırılır.");
        }
    }


    class IK:Personel //Kalıtım yapıldı. Personel sınıfının özellikleri IK aktarıldı.
    {
        public int PersonelSayisi { get; set; }
    }

    class IT:Personel
    {
        public int ProgramSayisi { get; set; }
    }

    class MUH:Personel
    {
        public int HesapSayisi { get; set; }
    }

}
