﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziGenel
    {
        public static void Main(string[] args)
        {

            #region 1. Dizi tanımlama, değer atama, kullanma

            int[] sayilar = new int[20]; // 20 elemanlık sayılar isminde bir dizi tanımı
            string[] names = new string[20]; // 20 elemanlık string dizi oluşturdumç İsmi de names

            // bir değer atamak istersem 

            sayilar[5] = 30;

            names[10] = "Sinem";
            names[11] = "30";

            Console.WriteLine("Sayısal dizi sayilar'ın 5. indexindeki değer {0}", sayilar[5]);

            Console.WriteLine("Metinsel dizi names'in 10. indexindeki değer {0}", names[10]);

            Console.WriteLine("Metinsel dizi names'in 11. indexindeki değer {0}", names[11]);

            int sayi1 = sayilar[5];
            int sayi2 = Convert.ToInt32 (names[11]);  


            
            
            Console.WriteLine("Toplam {0}", sayi1 + sayi2);



            #endregion




            Console.ReadKey();


        }
    }
}
