using System.ComponentModel;

namespace _16_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap : Barkod,Yazar Adı,Kitap Adı

            List<Kitap> kitaps = new List<Kitap>();

            //Kitap.Kayit(kitaps);
            //Kitap.Yazdir(kitaps);

            while (true)
            {
                Console.WriteLine("1-Kitap Kaydet\n2-Kitap Sil\n3-Kitap Güncelle\n4-Kitap Listele\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Kitap.Kayit(kitaps);
                }
                else if (secim == 2)
                {
                    Kitap.Sil(kitaps);
                }
                else if (secim == 3)
                {
                    Kitap.Guncelle(kitaps);

                }
                else if (secim == 4)
                {
                    Kitap.Yazdir(kitaps);
                }
            }



        }
    }

    class Kitap
    {
        int Barkod;
        string YazarAdi;
        string KitapAdi;

        public static void Kayit(List<Kitap> kitaplar)
        {
            Kitap kitap = new Kitap(); //object - nesne

            Console.WriteLine("Barkod:");
            kitap.Barkod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kitap Adı:");
            kitap.KitapAdi = Console.ReadLine();

            Console.WriteLine("Yazar Adı:");
            kitap.YazarAdi = Console.ReadLine();

            kitaplar.Add(kitap);

        }

        public static void Yazdir(List<Kitap> kitaplar)
        {
            foreach (var item in kitaplar)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Barkod);
                Console.WriteLine(item.KitapAdi);
                Console.WriteLine(item.YazarAdi);
            }
        }

        public static void Sil(List<Kitap> kitaplar)
        {
            Yazdir(kitaplar);
            Console.WriteLine("Silinecek Kitap Barkod:");
            int barkod = Convert.ToInt32(Console.ReadLine());

            Kitap silinecek = kitaplar.Where(i => i.Barkod == barkod).FirstOrDefault();

            if (silinecek != null)
            {
                kitaplar.Remove(silinecek);
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }

        }

        public static void Guncelle(List<Kitap> kitaplar)
        {
            Yazdir(kitaplar);
            Console.WriteLine("Güncellenecek Kitap Barkod:");
            int barkod = Convert.ToInt32(Console.ReadLine());

            Kitap guncelle = kitaplar.Where(i => i.Barkod == barkod).FirstOrDefault();

            if (guncelle != null)
            {
                Console.WriteLine("Barkod:");
                guncelle.Barkod = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kitap Adı:");
                guncelle.KitapAdi = Console.ReadLine();

                Console.WriteLine("Yazar Adı:");
                guncelle.YazarAdi = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kitap Bulunamadı.");
            }

        }
    }
}
