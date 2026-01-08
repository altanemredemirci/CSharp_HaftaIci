namespace _12_Metotlar_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı

            int[] sayilar = new int[10];

            DiziIslemleri.SayiUret(sayilar);

            DiziIslemleri.DiziYazdir(sayilar);

            int enBuyukDeger = DiziIslemleri.EnBuyukDeger(sayilar);

            int enKucukDeger = DiziIslemleri.EnKucukDeger(sayilar);


            Console.WriteLine("En Büyük Değer:"+enBuyukDeger);

            Console.WriteLine($"En Küçük Değer:{enKucukDeger}");
        }
    }
}
