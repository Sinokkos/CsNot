using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO7_Functions
{
    internal class MathFunctions
    {
        public static void Main(string[] args)
        {

            #region 1. Abs metodu- Absolute.. Mutlak değer
            // verilen bir sayının matematiksel olarak mutlak değerini almak için kullanılır. Abs metodu parametre olarak farklı veri türlerinde değer alabilir. Sonuç aldığı türden verilir. Yani int ise int, double ise double gibi...

            //int sayi1 = -5;
            //double sayi2 = -345.678;

            //int sonuc1= Math.Abs(sayi1);
            //Console.WriteLine($"Abs sonuc(int) {sonuc1}");

            //double sonuc2 = Math.Abs(sayi2);
            //Console.WriteLine($"Abs sonuc(double) {sonuc2}");

            //float, long, decimal, short...

            //Hack01
            //Klavyeden alınan bir sayının  mutlak değerini bulan ve yazdıran pp

            //Console.WriteLine("Lütfen sayınızı giriniz...");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Abs sonuc(int) {Math.Abs(sayi3)}\n\n");







            #endregion

            #region 2. Min-Max
            //int sayi4 = 5;
            //int sayi5 = 15;

            ////int sonuc4= Math.Min(sayi4, sayi5); 
            //Console.WriteLine($"Küçük olan : {Math.Min(sayi4, sayi5)}"); // Böyle de kullanabiliriz...

            //Console.WriteLine($"Büçük olan : {Math.Max(sayi4, sayi5)}");

            //// diğer veri tipleri için de aynı tür kullanılır...

            #endregion

            #region 3.Pow
            //int sayi6 = 2;
            //int sayi7 = 3;

            //Console.WriteLine($"2 nin küpü : {Math.Pow(sayi6, sayi7)}");
            //Console.WriteLine($"3 ün karesi : {Math.Pow(sayi7, sayi7)}");


            #endregion

            #region 4. Round- Yuvarlama
            // parametre olarak verilen ondalıklı sayıyı en yakın tamsayıya yuvarlama işlemi yapıyor

            //Console.WriteLine($"Yuvarlama 1 - {Math.Round(0.5)}\n\n");
            //Console.WriteLine($"Yuvarlama 2 - {Math.Round(3.01)}\n\n");
            //Console.WriteLine($"Yuvarlama 3 - {Math.Round(3.49)}\n\n");
            //Console.WriteLine($"Yuvarlama 4 - {Math.Round(3.51)}\n\n");
            //Console.WriteLine($"Yuvarlama 5 - {Math.Round(3.50)}\n\n");




            #endregion

            #region  5.- SquareRoot - Karakök

            //Console.WriteLine($"Karakök 1 - {Math.Sqrt(4)}\n\n");
            //Console.WriteLine($"Karakök 2 - {Math.Sqrt(3.01)}\n\n"); 
            //Console.WriteLine($"Karakök 3 - {Math.Sqrt(3.49)}\n\n");
            //Console.WriteLine($"Karakök 4 - {Math.Sqrt(3.51)}\n\n");
            //Console.WriteLine($"Karakök 5 - {Math.Sqrt(3.50)}\n\n");

            #endregion

            #region 6. Ceiling
            //parametrik olarak verilen ondalıkl sayısı yukarıya veya eğer bir tamsayı verilmişse tamsayının aynısına yuvarlama yapar.


            //Console.WriteLine($"Tavana yuvarlama 1 - {Math.Ceiling(4.0)}\n\n");
            //Console.WriteLine($"Tavana yuvarlama 2 - {Math.Ceiling(3.01)}\n\n");
            //Console.WriteLine($"Tavana yuvarlama 3 - {Math.Ceiling(3.49)}\n\n");
            //Console.WriteLine($"Tavana yuvarlama 4 - {Math.Ceiling(3.51)}\n\n");
            //Console.WriteLine($"Tavana yuvarlama 5 - {Math.Ceiling(3.50)}\n\n");





            #endregion





            Console.ReadKey();
        }
    }
}
