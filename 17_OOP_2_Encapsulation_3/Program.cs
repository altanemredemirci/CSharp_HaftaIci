namespace _17_OOP_2_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Banka Hesap kayıt işlemi burada girilen Iban bilgisinin TR+12 basamaklı rakamlar dizisi olmasını kontrol ediniz. 
             
             */

            Banka banka = new Banka()
            {
                _Iban = "TR123456789098"
            };

            Console.WriteLine(banka._Iban);
        }
    }

    class Banka
    {
        private string Iban;

        public string _Iban
        {
            get { return Iban; }
            set
            {
                if (value.Length == 14 && value.StartsWith("TR") && long.TryParse(value.Substring(2), out _))
                {
                    Iban = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Iban");
                }
            }
        }
    }

}
