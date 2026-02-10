namespace _17_OOP_2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             DATA ACCESS MODIFIER
            *public
            *private
            *internal
            *protected
            *internal protected


             */

            //********* ENCAPSULATION **********
            //Belirli bir property gizli tanımlayarak kullanıcının erişimine kapatılır. Gizli property proje için önemli bilgi barındıracağı için kullanıcının direk kullanımına kapanır. Kullanıcıdan public tanımlı başka bir property data girmesi istenir ve girilen data belirli kontrollerden geçirildikten sonra gizli property e atanır.

            //Mesela bir tc kimlik numarası girişinde 11 haneli rakamlardan oluşma kuralı vardır.Bu sebeple kullanıcıdan bir data alındıktan sonra kontroller yapılarak class'ın TC property sine atama yapılır.

            //Gizli property e data atamak için set metot, gizli property okunmak için get metot kullanılır.

            Vatandas vatandas = new Vatandas();
            vatandas.Ad = "Altan Emre";
            vatandas.Soyad = "Demirci";
            vatandas._TC = 12345678901; //11 haneli rakamlar dizisidir.


            Console.WriteLine(vatandas.Ad);
            Console.WriteLine(vatandas.Soyad);
            Console.WriteLine(vatandas._TC);
        }
    }

    class Vatandas
    {
        private long TC;
        public string Ad;
        public string Soyad;


        public long _TC 
        {
            get { return TC; } //private tanımlı değişkeni sınıf dışından okumamızı sağlar. 
            set //private tanımlı değişkene belirli kontroller sonucunda değer atamaya yarar.
            {
                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    Console.WriteLine("TC 11 haneli olmalıdır.");
                }
            } 
        }
    }
}
