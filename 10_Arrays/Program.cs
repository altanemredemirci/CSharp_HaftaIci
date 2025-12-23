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

            //int sayi = 10;

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
            /*
             int[] sayilar = new int[5];


             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine("Sayı:");
                 sayilar[i] = Convert.ToInt32(Console.ReadLine());
             }


             //int j = 0;
             //while (j < 5)
             //{
             //    Console.WriteLine("Sayı:");
             //    sayilar[j] = Convert.ToInt32(Console.ReadLine());
             //    j++;
             //}


             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine(sayilar[i]);
             }
         */

            #endregion

            #region Kullanıcıdan kaç personeli olduğu bilgisini alınız. Daha sonra personel isimlerini kullanıcıdan alarak diziye ekleyiniz.

            //Console.WriteLine("Personel Sayınız?");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] isimler = new string[personelSayisi];

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine("İsim:");
            //    isimler[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < personelSayisi; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}



            #endregion

            //FOREACH:Bu döngü bir koleksiyonu ekrana yazdırmak için kullanılır.

            //int[] sayilar = { 11, 22, 33, 44, 55, 66 };



            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #region ARRAY SINIFININ METOTLARI
            //int[] sayilar = { 11, 22, 33, 44, 55, 66 };

            #region CLEAR()

            //Array.Clear(sayilar); //Dizi içindeki bütün değerleir siler.

            //Array.Clear(sayilar, 1, 2);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region COPY()
            //Belirli bir koleksiyondan bir diğeri değer kopyalayı sağlar.

            //int[] sayilar2 = new int[10];

            //Array.Copy(sayilar, sayilar2, 3); //(kaynakdizi,hedefdizi,adet)

            //Array.Copy(sayilar, 2, sayilar2, 5, 3);


            //foreach (int item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region INDEX OF()
            //Bir Koleksiyon içerisinde bir değerin ilk bulunduğu Index numarasını bulmamızı sağlar.

            //int index = Array.IndexOf(sayilar, 33);

            //Console.WriteLine(index);

            //string[] isimler = { "Ali", "Veli", "Ali", "Emre", "Kıvanç", "Ali", "Kerem", "Uras", "Ali" };

            //Console.WriteLine(Array.IndexOf(isimler,"Ali"));

            //Console.WriteLine(Array.IndexOf(isimler,"Ali",1));

            //Bir döngü yardımıyla isimler dizisindeki bütün Ali lerin Index numaralarını ekrana yazdırınız

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (isimler[i] == "Ali")
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int indx = -1;

            //while (indx < isimler.Length)
            //{
            //    indx = Array.IndexOf(isimler, "Ali", indx+1);
            //    if (indx == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(indx);
            //}



            #endregion

            #region LAST INDEX OF()
            //Bir Koleksiyon içerisinde bir değerin son bulunduğu Index numarasını bulmamızı sağlar.

            //string[] isimler = { "Ali", "Veli", "Ali", "Emre", "Kıvanç", "Ali", "Kerem", "Uras", "Ali" };
            //Console.WriteLine(Array.LastIndexOf(isimler,"Ali"));

            #endregion

            #region SORT()

            //string[] isimler = { "Zehra", "Ali", "Davut", "Bilal", "Songül", "İbo", "Çetin","Şakir" };
            //Array.Sort(isimler);

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region REVERSE()
            //string[] isimler = { "Zehra", "Ali", "Davut", "Bilal", "Songül", "İbo", "Çetin", "Şakir" };
            //Array.Sort(isimler);
            //Array.Reverse(isimler);

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region RESIZE()

            //int[] rakamlar = new int[4];
            //rakamlar[0] = 11;
            //rakamlar[1] = 22;
            //rakamlar[2] = 33;
            //rakamlar[3] = 44;
            //Array.Resize(ref rakamlar, 5);
            //rakamlar[4] = 55;

            #endregion


            #endregion


            #region Verilen bir string değerin harflerini alt alta yazdırma

            //string il = "İSTANBUL";

            //for (int i = 0; i < il.Length; i++)
            //{
            //    Console.WriteLine(il[i]);
            //}

            //foreach (char item in il)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında rastgele atansın.
            //Bu dizinin elemanlarını da sistem 0,100 aralığında otomatik atasın.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizinin en büyük ve en küçük değerini sort() metodunu kullanmadan ekrana yazdırınız.

            //Random r = new Random();
            //int uzunluk = r.Next(10, 20);

            //int[] sayilar = new int[uzunluk];

            //int i = 0;
            //while(i<uzunluk)
            //{
            //    int sayi = r.Next(1, 100);

            //    if (sayilar.Contains(sayi) == false)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }               
            //}


            //Console.WriteLine("Eleman Sayısı:"+uzunluk);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];

            //foreach (int item in sayilar)
            //{
            //    if (item > enBuyuk)
            //    {
            //        enBuyuk = item;
            //    }
            //    if (item < enKucuk)
            //    {
            //        enKucuk = item;
            //    }
            //}

            //Console.WriteLine("Enbüyük:"+enBuyuk);
            //Console.WriteLine("Enküçük:"+enKucuk);

            #endregion

            #region Kullanıcıdan 4 ürün fiyatı isteyin fiyatı 1200 tl yi geçen ürünlere %32 indirim yapınız ve 
            //      her biri ürünün yeni fiyatını gösteriniz

            double[] urunler = new double[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ürün Fiyatı:");
                double fiyat = Convert.ToDouble(Console.ReadLine());

                if (fiyat > 1200)
                {
                    fiyat = fiyat * 0.68;
                }

                urunler[i] = fiyat;
            }

            foreach (double item in urunler)
            {
                Console.WriteLine(item);
            }


            #endregion
        }
    }
}
