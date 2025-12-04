namespace _02_Degiskenler_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region******** DEĞİŞKENLER **********
            /*Değişkenler yazılım içerisinde data tanımlama,data tutma,taşıma ve işlem sonucu tutmak için kullanılan yazılım yapılarıdır.
            *Tek bir data tutabilirler
                * sayi=1
                * ad="Altan"
            *Ram bellekte tanımlanırlar. Bu sebeple program durduğunda silinirler.
             
            **Değişken İsimlendirme Kuralları
                yanlışlar: 1sayi, ?sayi, sa!yi, ad soyad, ad-soyad
                doğrular:  sayi1, _sayi, sayi_, ad_soyad, adsoyad
                ** _ alt çizgi bütün yazılım dillerinde geçerli tek özel karakterdir.
             

            //Değişken tanımlama
            //veritipi değişkenadı = değer 
            int sayi = 0;
            int sayi2 = 12;


            long tc = 12345678901;


            int sayi3 = 1234567;


            SnakeCase: ad_soyad
            CamelCase: adSoyad
            UpperCase: ADSOYAD
            LowerCase: adsoyad
            KebabCase: ad-soyad
            PascalCase: AdSoyad


             */
            #endregion


            #region VERİ TİPLERİ
            /* Değişken tanımlarken o değişkenin sayısal mı, sözel mi değer tutacağını belirtmeliyiz.Sayısal ise tam sayı mı, ondalıklı sayı mı? olduğunu belirtmeliyiz.
             

            **SAYISAL VERİ TİPLERİ:**
            INTEGER(tam sayı): sbyte,byte,short,ushort,int,uint,long,ulong
                int sayi = 19;

            REAL(ondalıklı sayı): float,double
                float sayi = 15.5f;
                double sayi2 = 15.5;

            DECIMAL: decimal
                decimal sayi = 15;
                decimal sayi2 = 15.5m;

            **SOZEL VERİ TİPLERİ:**
            char: Tek karakter tanımlanır. ' ' ile tanımlanır.
                char harf = 'A';
                char sayi = '1';

            string: " çift tırnak ile tanımlanır. ram bellek boyutunda data tutar.
                string isim = "Emre";

            **MANTIKSAL VERİ TİPİ:**
            bool(Boolean): Bir karşılaştırma veya kıyas sonucu True veya False cevabı döner. Bu cevap bool veri tipinde tutulur.


             
            decimal sayi2 = 15.5m;
            short sayi1 = 2553;

            long sayi = 1098798798789798;

            string adSoyad = "Altan Emre Demirci";

            //int sayi = 10;
            //Console.WriteLine(adSoyad);
            //Console.WriteLine(sayi);


            int sonuc = 5 + 3;

            bool sonuc = 5 < 3;
            Console.WriteLine(sonuc);
            */




            #endregion


            #region SCOPE - KAPSAM

            //int b = 10;
            //{
            //    int a = 5;
            //    Console.WriteLine(b);
            //}
            //{
            //    Console.WriteLine(a); //HATA: Kapsam dışında tanımlı olması nedeniyle erişilemez.
            //    Console.WriteLine(b);
            //}


            //Console.WriteLine(b);



            //{
            //    int c;
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            #endregion


            #region Constant

            int sayi = 5;
            //int sayi = 10; //HATA: Tanımlanmış bir değişkeni ikinci defa tanımlayamam

            sayi = 10; //Tanımlı değeri revize ettim


            const int sayi2 = 100;

            sayi2 = 120; //HATA:Constant sabit değer anlamına gelir. Tanımlandıktan sonra değiştirilemez.


            #endregion
        }
    }
}
