using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziMetotlari
    {
        public static void Main(string[] args)
        {

            #region Dizilerde kullanılan bazı metotlar
            //Getlength

            int[] sayilar1 = { 1, 2, 87, 56, 76 };
            int[] sayilar2 = { 43, 67, 456, 3, 7 };
            Console.WriteLine("sayılar1 dizisinin boyutu (GetLenght metodu ile)  : " + sayilar2.GetLength(0) + "\n\n"); // o parametresi dizi boyutunu gösteriyor.
            Console.WriteLine("sayılar1 dizisinin boyutu (Lenght metodu ile) : " + sayilar2.Length + "\n\n");

            // Çok boyutlu dizi tanımlama (dizi içinde dizi)
            int[,] sayilar3 = { {2, 4, 3, 7 },{4, 7, 12, 17 }, {12, 54, 78,8 } };
            //3x4 lük bir dizi var karşımda

            byte boyut3= (byte)sayilar3.GetLength(1);


            #endregion



            Console.ReadKey();
        }
    }
}