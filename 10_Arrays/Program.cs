namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ******** ARRAYS - DİZİLER ********
            * Değişkenler tek bir veri tutarken, diziler aynı veri tipinde birden fazla veriyi tutabilirler.
            * Index adı verilen 0'dan başlayarak 1'er 1'er artan numaralandırma yöntemi ile verileri sıralı tutarlar. 
            * Dizilerin kendilerine ait metotları vardır.
            * Dizi tanımlanırken veri tipi ve kaç veri tutacağı belirtilmelidir.
             
             */

            int sayi = 10;

            //**Dolu Dizi Tanımı
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8 }; //8 adet int tipinde sayı tutan bir sayilar dizisidir.

            //**Dizi Elemanını Ekrana Yazdırma
            //Console.WriteLine(sayilar[2]);

            //**Boş Dizi Tanımı
            //string[] isimler = new string[10]; //10 adet değer tutabilir.

            //isimler[2] = "Altan Emre";

            //Console.WriteLine("Adınız:");
            //isimler[0] = Console.ReadLine();


            #region Kullanıcıdan alınacak 5 sayıyı bir diziye yazdırınız. Daha sonrada sayıları ekran yazdırınız.

            int[] sayilar = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayı:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("Sayı:");
                sayilar[j] = Convert.ToInt32(Console.ReadLine());
                j++;
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        

            #endregion


        }
    }
}
