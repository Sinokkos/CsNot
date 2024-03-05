﻿using System;
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

            //int[] sayilar1 = { 1, 2, 87, 56, 76 };
            //int[] sayilar2 = { 43, 67, 456, 3, 7 };
            //Console.WriteLine("sayılar1 dizisinin boyutu (GetLenght metodu ile)  : " + sayilar2.GetLength(0) + "\n\n"); // o parametresi dizi boyutunu gösteriyor.
            //Console.WriteLine("sayılar1 dizisinin boyutu (Lenght metodu ile) : " + sayilar2.Length + "\n\n");

            // Çok boyutlu dizi tanımlama (dizi içinde dizi)
            //int[,] sayilar3 = { {2, 4, 3, 7, 5 },{4, 7, 12, 17, 4 }, {12, 54, 78, 45, 30 } };
            ////3x5 lük bir dizi var karşımda

            //byte boyut3= (byte)sayilar3.GetLength(1); // Parantez içinde yazılanlar boyutlarımızı veriyor. 0 dan başlayarak süslü parantez içerisine doğru gideriz!!!


            #endregion

            #region diğer bir kullanım
            int[][] dizi16 = new int[3][];

            dizi16[0] = new int[] { 1, 2, 3 }; 
            dizi16[1] = new int[] { 4, 5, 6, 7 };
            dizi16[2] = new int[] { 8, 9 };
            // dizinin bütün elemanlarını teker teker ekrana yazdıran pp

            for (int i = 0; i < dizi16.GetLength(0); i++) // dikey gibi düşünebiliriz
                for (int j = 0; j < dizi16[i].GetLength(0); j++) // yatay gibi düşünebiliriz
                    //Console.WriteLine("dizi16[{0}][{1}]={2}", i, j, dizi16[i][j]);
                    Console.WriteLine($"dizi16[{i}][{j}]={dizi16[i][j]}"); //$ ile yazdıldığında da böyle oluyor...

            #endregion




            Console.ReadKey();
        }
    }
}