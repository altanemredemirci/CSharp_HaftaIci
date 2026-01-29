namespace _11_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(sayi/0);
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("Sayıyı rakam olarak giriniz");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölünme hatası");
            //}
            //catch
            //{
            //    Console.WriteLine("Bilinmeyen hata.Lütfen sistem yöneticiniz ile iletişime geçiniz.");
            //}

            //try
            //{
            //    Console.WriteLine("Sayı:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Hata:"+e.Message);
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Sayı:");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Hata:" + e.Message);
            //    }
            //}



            //SORU: Kullanıcıdan 2 sayı alınız. girilen her değeri kontrol ederek doğru olması halinde toplayınız. 2. sayı hatalı ise 1.sayı tekrar sorulmasın.

            int sayi1, sayi2;

            while (true)
            {
                try
                {
                    Console.WriteLine("Sayı:");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Giriş!");
                }


            }

            while(true)
            {
                try
                {
                    Console.WriteLine("Sayı2:");
                    sayi2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Toplam:"+(sayi1+sayi2));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Giriş!");
                }

            }
            

        }

    }
}
