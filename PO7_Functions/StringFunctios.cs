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
            string metin = "\tArı Bilgi Yazılım Eğitimi";
            Console.WriteLine($"Metnin : {metin}"); //boşluklar da dahil
            Console.WriteLine($"Metnin uzunluğu : {metin.Length}"); //boşluklar da dahil




            #endregion

            #region 2. ToLower/ToUpper

            Console.WriteLine($"Metnin küçük hali : {metin.ToLower()}");
            Console.WriteLine($"Metnin büçük hali : {metin.ToUpper()}");



            #endregion

            #region 3. Concat - Concatenate

            string metin1 =Console.ReadLine();
            string metin2=Console.ReadLine();

            string sonuc=String.Concat(metin1, " ","\t", metin2);
            Console.WriteLine($"Concat sonrası:  {sonuc}");
            

            #endregion

            Console.ReadKey();
        }
    }
}
