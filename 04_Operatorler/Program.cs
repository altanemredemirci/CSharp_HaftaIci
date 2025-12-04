using System.Data.SqlTypes;

namespace _04_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OPERATÖRLER

            #region *** MATEMATİKSEL OPERATÖRLER (+,-,*,/,%)
            //int sayi = 10;
            //double sayi2 = 4.0;

            //Mod Alma
            //Console.WriteLine(sayi%sayi2);


            //Bölme işleminde, işleme uğrayan sayılardan biri dahi ondalıklı ise sonuç ondalıklı ama her iki sayıda int ise sonuç int çıkar.

            //Console.WriteLine(sayi/sayi2);


            #endregion

            #region *** ATAMA(=) ve İŞLEMLİ ATAMA OPERATÖRLERİ

            //int sayi = 5;

            //sayi += 5; //sayi = sayi + 5;
            //sayi -= 5; //sayi = sayi - 5;
            //sayi *= 5; //sayi = sayi * 5;
            //sayi /= 5; //sayi = sayi / 5;


            #endregion

            #region *** BİR ARTTIRMA VE BİR AZALTMA 

            //int sayi = 10;

            ////sayi++;   //sayi+=1;
            ////sayi--;   //sayi-=1;


            //int b = sayi++; //b=10 sayi=11
            //int c = ++sayi; //c=12  sayi=12
            //int d = b / c;  //d=0

            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);




            #endregion

            #region *** KARŞILAŞTIRMA OPERATÖRLERİ 

            //int sayi = 5;
            //int sayi2 = 6;

            //bool sonuc = sayi < sayi2;
            //bool sonuc2 = sayi > sayi2;
            //bool sonuc3 = sayi <= sayi2;
            //bool sonuc4 = sayi >= sayi2;
            //bool sonuc5 = sayi == sayi2; // iki değer birbirine eşit mi?
            //bool sonuc6 = sayi != sayi2; // iki değer birbirinden farklı mı?

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);
            //Console.WriteLine(sonuc5);
            //Console.WriteLine(sonuc6);


            //string username = "altanemre";

            //Console.WriteLine("Kullanıcı Adı:");
            //string kullaniciadi = Console.ReadLine();


            //bool girisDurumu = username == kullaniciadi;

            //Console.WriteLine("Giriş:"+girisDurumu);



            #endregion

            #region *** KIYAS OPERATÖRÜ(?:)
            //Bir karşılaştırmanın doğru(True) ve yanlış(False) durumlarında ne yapacağını belirleriz.

            //int sayi = 5;

            ////sayi 4 den büyük ise BÜYÜK değilse KÜÇÜK değerini sonuc değişkenine ata.
            //string sonuc = sayi > 4 ? "BÜYÜK" : "KÜÇÜK";



            #endregion

            #region *** ERİŞİM OPERATÖRÜ(.)
            //Belirli bir tanımın altındaki tanıma erişmeyi sağlar.
            //Console.ReadLine().ToString();

            //Convert.ToString().ToUpper();
            #endregion

            #region *** MANTIKSAL OPERATÖRLER
            #region AND OPERATÖRÜ (&&) 
            //Birden fazla karşılaştırma durumunun kontrol edilmesi ve her durumun true olması gerekliyse kullanılır.


            //string username = "altanemre";
            //string password = "123";

            //Console.WriteLine("Kullanıcı Adı:");
            //string kullaniciadi = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();

            //bool sonuc = username==kullaniciadi  &&  password == sifre; 

            //Console.WriteLine(sonuc);


            #endregion

            #region OR OPERATÖRÜ (||) 
            //Birden fazla karşılaştırma durumunun kontrol edilmesi ve bir durumun true olması yeterliyse kullanılır.
            //string username = "altanemre";
            //string email = "altanemre@gmail.com";


            //Console.WriteLine("kullanıcıadı/email:");
            //string kullanici = Console.ReadLine();

            //bool sonuc = kullanici == username || kullanici == email;

            //Console.WriteLine(sonuc);


            #endregion

            #endregion


            //Bir sürücü adayının ehliyet alma şartları yaşı 17 den büyük ve Lise mezunu veya erkek olması

            //Console.WriteLine("Yaş:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mezuniyet:");
            //string mezun = Console.ReadLine();

            //Console.WriteLine("Cinsiyet:");
            //string cins = Console.ReadLine().ToLower(); //girilen değeri küçük harfe çevirir.


            //bool sonuc = (yas > 17 && mezun == "lise") || cins == "erkek";


            //string durum = sonuc == true ? "ehliyet alabilir" : "ehliyet alamaz";


            //Console.WriteLine(durum);

            #endregion

            //int sayi = 10;
            //int sayi2 = 3;

            //Console.WriteLine(sayi%2==1);


        }
    }
}
