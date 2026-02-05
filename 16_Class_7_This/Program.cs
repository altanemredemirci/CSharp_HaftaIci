namespace _16_Class_7_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Altan", "Emre");
        }
    }

    class Customer
    {
        public int Id;
        public string Name; 
        public string Surname;

        public Customer(int Id,string Name, string Surname)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }

    }
}
