using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziDongu
    {
        public static void Main(string[] args)
        {
            #region for/ foreach döngülerinin kullanımı
            // Verilen bir tam sayı dizisinin elemanlarının toplamını
            //hem for hem de foreach döngülerini kullanarak ayrı ayrı geliştiriniz.

            //for
            //int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 30 };
            //int toplam1 = 0; // toplamı tutacak

            //for (int index = 0; index < sayilar1.Length; index++)
            //{
            //    toplam1 += sayilar1[index]; // anında atama.. sayilar1 dizisinin indexinci elamanının değeri al toplamına ekle
            //}

            //Console.WriteLine($"for çevrimiyle elde edilen sonuç: {toplam1} ");


            //// foreach ile 
            //int toplam2 = 0;

            //foreach (int deger in sayilar1)
            //{
            //    toplam2+= deger;
            //}

            //Console.WriteLine($"foreach çevrimiyle elde edilen sonuç: {toplam2} ");


            #endregion

            #region Hack02 (Workout)
            // Tanımlanan sayısal bir dizi içerisindeki sayıların negatif, pozitif, nötr olma durumlarını sayının yanına yazan programı parçacığı geliştiriniz.
            //Örnek
            //0     Nötr
            // 5    Pozitif
            //- 7   Negatif
            //...
            //şeklinde


            // Hack02 ye ek
            // Bir de acaba pozitifden, negatiften, nötrden kaçar tane var? Bunları da çıkışta görebilelim
            //pozitiflerin adedi...
            //negatiflerin adedi...
            //nötrlerin adedi...

            //int[] sayilar = { 4, 5 - 15, 22, -34, 3, 0, 100 };
            //int pozadet = 0;
            //int negadet = 0;
            //int notradet = 0;


            ////foreach kullanın

            //foreach (int sayi in sayilar)
            //    {
            //        //gelen sayının büyük 0 mı küçük 0 mı olduğunu anlamam lazım ki yanına hangi türden olduğunu yazabileyim
            //        if (sayi > 0)
            //        {
            //            Console.WriteLine(sayi + "\tPozitiftir...");
            //            pozadet++;
            //        }

            //        else if (sayi < 0)
            //        {
            //            Console.WriteLine(sayi + "\tNegatiftir...");
            //            negadet++;
            //        }
            //        else
            //        {
            //            Console.WriteLine(sayi + "\tNötrdür...");
            //            notradet++;
            //        }

            //    }

            //Console.WriteLine($"Pozitif sayıların adedi : {pozadet} ");
            //Console.WriteLine($"Pozitif sayıların adedi : {negadet} ");
            //Console.WriteLine($"Pozitif sayıların adedi : {notradet} ");

            #endregion

            #region Hack03 (Workout)
            //// Kullanıcıdan alınan bir metin içindeki sesli harf sayısını bulan ve bulduklarını başka bir diziye yerleştiren p. parçacığını tasarlayınız.

            //// Öncelikle seslerin olduğu bir dizi tanımı yapıyorum.
            //char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', };

            //// Bulacağım seslileri yerleştireceğim bir dizi
            //char[] hangileri = new char[20];


            //string metin = ""; //ekrandan alacağım metin bilgisi
            //int hindex = 0; //hangileri dizisinin index bilgisini tutacak
            //int adet = 0; //bulduğum sesli harf adedini tutacak

            //Console.WriteLine("Lütfen metni giriniz :");
            //metin = Console.ReadLine().ToLower();
            //// Büyük harf girse bile küçüğe çevirdim

            ////  Not : aslında geri planda metin bilgisi de bir dizi gibi algılanabilir. {0, 1, 2..} gibi

            //// sesliler dizisiyle işe başlayacağız. 
            //// 1. for çevrimi sesliler dizisi içinde hareket edecek.

            //for (int sesliindex = 0; sesliindex < sesliler.Length; sesliindex++)
            //{
            //    // 2.for çevrimi metin dizisi içinde hareket edecek
            //    // metnin başından sonuna kadar ilerlenecek
            //    for (int metinindex=0; metinindex < metin.Length; metinindex++)
            //    {
            //        // eğer metin içindeki bir karakter benim sesli içindeki karaktere uyuyor mu?
            //        if (metin[metinindex] == sesliler[sesliindex]) 
            //        {
            //            // başka bir diziye taşıyayım.
            //            hangileri[hindex] = metin[metinindex]; // bulduğum sesli harfin ne olduğunu metin [metinindex] ile bilebiliyorum
            //            hindex++; // bir sonraki eleman için
            //            adet++; // Bulduğum sesli harf adedini arttırıyorum.
            //        }

            //    }
                
            //    // iç içe for olayında en önce içteki for biter sonra dıştaki for a dönülür. Sora o biter.




            //}

            //Console.WriteLine($"Girmiş olduğunuz metinde {adet} adet sesli harf vardır.\n\n");
            //Console.WriteLine(hangileri);


            #endregion

            Console.ReadKey();

        }
    }
}