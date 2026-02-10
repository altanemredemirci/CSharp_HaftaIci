using System.Reflection;

namespace _16_Class_6_Enum_2
{
    enum Markalar
    {
        Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo
    }
    enum Vitesler { Otomatik, Manuel, Yarı_Otomatik }
    enum Renkler { Beyaz, Sarı, Kırmızı, Mavi, Siyah }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region SORU
            /*
             SORU: Aşağıdaki sınıfları tanımlayınız. 
            Otomobil ve Ticari sınıfları var.
            Her sınıfa ait tüm sınıf özelliklerine atama yapan yapıcı(Constructor)
            metotlar tanımlanacaktır.
            Main içinden 2 nesne ile örneklendiriniz.
            Nesneler sadece türetilen sınıfların yapıcı metotları kullanılarak
            oluşturulacak.
            Sabit veri tipleri:(enum)
            ----------------------
            Marka:
            Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş,Lamborghini,Ferrari,Sca
            nia,Volvo
            Vites: Manuel, Otomatik, Yarı_Otomatik
            Renk: Kırmızı,Beyaz,Siyah,Turuncu,Yeşil,Mavi,Mor
            
            SınıfAdı: Otomobil
            -------------------------
            Marka,
            Vites,
            Renk,
            protected MotorHacmi,
            KapiSayisi,
            Model,
            Ceker4, (4x4 mü?)
            ParkSensoru, (Park sensörü var mı?)
            
            public void OtomobilBilgiYaz() => Araca ait tüm bilgileri ekrana
            yazdırsın.


            SınıfAdi: Ticari
            -------------------------
            Marka,
            Vites,
            Renk,
            protected MotorHacmi,
            TasimaKapasitesi,
            Ceker4, (4x4 mü?)
            YolcuKapasitesi
            
            public void TicariBilgiYaz() => Araca ait tüm bilgileri ekrana
            yazdırsın

            */
            #endregion

            Otomobil otomobil = new Otomobil(Markalar.Ferrari, Renkler.Siyah, Vitesler.Otomatik, 5000, 2,"F350", false, true);
            otomobil.OtomobilBilgiYaz();

            Ticari ticari = new Ticari(Markalar.Scania, Renkler.Mavi, Vitesler.Otomatik, 50000, 3, true);
            ticari.TicariBilgiYaz();

        }
    }

    class Otomobil
    {
        public Markalar Marka;
        public Renkler Renk;
        public Vitesler Vites;
        public int MotorHacmi;
        public int KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;


        public Otomobil(Markalar marka,Renkler renk,Vitesler vites,int motorHacmi,int kapiSayisi,string model,bool ceker4,bool parkSensoru)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            MotorHacmi = motorHacmi;
            KapiSayisi = kapiSayisi;
            Model = model;
            Ceker4 = ceker4;
            ParkSensoru = parkSensoru;
        }

        public void OtomobilBilgiYaz()
        {
            Console.WriteLine("Marka:" + Marka);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Vites:" + Vites);
            Console.WriteLine("Renk:" + Renk);
            Console.WriteLine("Motor Hacmi:" + MotorHacmi);
            Console.WriteLine("Çeker:" + Ceker4);
            Console.WriteLine("Kapı Sayısı:" + KapiSayisi);
            Console.WriteLine("Park Sensörü:" + ParkSensoru);
        }

    }

    class Ticari
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int TasimaKapasitesi;
        public bool Ceker4;
        public int YolcuKapasitesi;

        public Ticari(Markalar marka, Renkler renk, Vitesler vites, int tasimaKapasitesi, int yolcuKapasitesi,bool ceker4)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            TasimaKapasitesi = tasimaKapasitesi;
            YolcuKapasitesi = yolcuKapasitesi;
            Ceker4 = ceker4;
        }

        public void TicariBilgiYaz()
        {
            Console.WriteLine("Marka:" + Marka);
            Console.WriteLine("Vites:" + Vites);
            Console.WriteLine("Renk:" + Renk);
            Console.WriteLine("YolcuKapasitesi:" + YolcuKapasitesi);
            Console.WriteLine("Çeker:" + Ceker4);
            Console.WriteLine("Taşıma Kapasitesi:" + TasimaKapasitesi);
        }

    }
}
