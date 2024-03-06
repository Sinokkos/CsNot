internal class Program
{
    private static void Main(string[] args)
    {
        #region 1. Hata oluşturabilecek bir durum

        //int sayi1 = 100;
        //int sayi2 = 0;

        //int sonuc= sayi1/sayi2;

        //Console.WriteLine($"Bölme işleminin sonucu: {sonuc}");





        #endregion

        #region 2. Hata Avcısı
        //int sayi1 = 100;
        //int sayi2 = 0;

        //avcı

        //try
        //{
        //    int sonuc = sayi1 / sayi2;
        //    Console.WriteLine($"Bölme işlemin sonucu: {sonuc}");
        //}
        //catch (Exception)
        //{

        //    //Console.WriteLine("Valla arkadaş... bir yerlerde terslik var");

        //    if (sayi1 !=0 && sayi2==0)
        //    {
        //        sayi2 = 1;
        //        int sonuc=sayi2 / sayi1;
        //        Console.WriteLine($"Durum düzeltildi...{sonuc}");
        //    }
        //}

        #endregion

        #region 3. Biraz daha detaylı örnek

        double bolunecek, bolen;

        try
        {

            Console.Write("Bölünecek değeri giriniz...");
            bolunecek=Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Bölen değeri giriniz...");
            bolen=Convert.ToInt32(Console.ReadLine());

            double sonuc = bolunecek/bolen;

            Console.WriteLine($"{bolunecek} değerinin {bolen} değerine bölümünün sonucu : {sonuc}...");

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Hata - Sıfıra bölüm işlemi gerçekleştirelemez...; Hata mesajı  : {e.Message} \n");

           
        }

        catch (FormatException e)
        {

            Console.WriteLine($"Hata - Sadece Int32 türünde veri girişi yapabilirsiniz...; Hata mesajı  : {e.Message} \n");
        }

        catch (OverflowException e) 
        {
            Console.WriteLine($"Hata - Değişken sınırlarını aştınız...; Hata mesajı  : {e.Message}\n");
        }

        catch (Exception e) //geri kalan tüm hata durumlarında
        {
            Console.WriteLine($"Hata - Beklenmedik hata ...; Hata mesajı  : {e.Message}\n");
        }

        finally 
        {
            Console.WriteLine("Finally bloğu çalışıyor..." );
        }

        #endregion

        Console.ReadKey();
    }
}