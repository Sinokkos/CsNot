using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO7_Functions
{
    internal class StringFunctios
    {
        public static void Main(string[] args)
        {
            #region 1. Length
            //string metin = "\tArı Bilgi Yazılım Eğitimi";
            //Console.WriteLine($"Metnin : {metin}"); //boşluklar da dahil
            //Console.WriteLine($"Metnin uzunluğu : {metin.Length}"); //boşluklar da dahil




            #endregion

            #region 2. ToLower/ToUpper

            //Console.WriteLine($"Metnin küçük hali : {metin.ToLower()}");
            //Console.WriteLine($"Metnin büçük hali : {metin.ToUpper()}");



            #endregion

            #region 3. Concat - Concatenate

            //string metin1 =Console.ReadLine();
            //string metin2=Console.ReadLine();

            //string sonuc=String.Concat(metin1, " ","\t", metin2);
            //Console.WriteLine($"Concat sonrası:  {sonuc}");


            #endregion

            #region 4. Compare/ Karşılaştırma

            // iki string bilginin karşılaştırılması için kullanılır
            // string ifadelerin 1. karakterinden itibaren "karakter=karakter" birebir olacak şekilde karşılaştırır. Ve buna göre geriye bir tam sayi değer döndürür.

            // Eğer geriye dönen değer;
            // o ise : karşılaştırdığım metinler tamamen aynıdır.
            // 1 ise : 1. metnin karşılaştırılan karakteri diğer karşılaştırılan karakterden BÜYÜK olduğu anlaşılır. (metin1 >m)
            // -1 ise: 1. metnin karşılaştırılan karakteri diğer karşılaştırılan karakterden KÜÇÜK olduğu anlaşılır. (metin1 <m)

            // Compare metodu büyük-küçük harfe duyarlı/duyarsız olarak çalışması düzenlenebilir.

            // Eğer böyle bir özellik verilmek istenirse Compare metoduna 3. bir parametre eklenir ve bu parametre boolean (true-false) olarak verilir.

            // Eğer;
            // true ise : büyük-küçük harf duyarsız olacaktır
            // false ise : büyük-küçük harf duyarlı olacaktır.

            //string metin1, metin2;

            //metin1 = "MCSD"; //?  0. İNDEX Mİ KARŞILAŞTIRIYOR? İlk karakter
            //metin2 = "mCSd"; //?

            //int sonuc= string.Compare(metin1, metin2);
            //int sonuc1= string.Compare(metin1, metin2, false);

            //switch (sonuc1)
            //{
            //    case 0:
            //        Console.WriteLine("metin1 ve metin2 tamamen aynıdır...\n");
            //        break;
            //        case 1:
            //        Console.WriteLine("metin1 ve metin2 den büyüktür...\n");
            //        break;
            //        case -1:
            //        Console.WriteLine("metin1 ve metin2 den küçüktür...\n");
            //        break;

            //    default:
            //        break;
            //}

            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            #endregion



            Console.ReadKey();


        }
    }
}
