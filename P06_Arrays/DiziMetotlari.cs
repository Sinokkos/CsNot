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

            #region 1.Dizilerde kullanılan bazı metotlar
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

            #region 2. diğer bir kullanım
            //int[][] dizi16 = new int[3][];

            //dizi16[0] = new int[] { 1, 2, 3 }; 
            //dizi16[1] = new int[] { 4, 5, 6, 7 };
            //dizi16[2] = new int[] { 8, 9 };
            //// dizinin bütün elemanlarını teker teker ekrana yazdıran pp

            //for (int i = 0; i < dizi16.GetLength(0); i++) // dikey gibi düşünebiliriz
            //    for (int j = 0; j < dizi16[i].GetLength(0); j++) // yatay gibi düşünebiliriz
            //        //Console.WriteLine("dizi16[{0}][{1}]={2}", i, j, dizi16[i][j]);
            //        Console.WriteLine($"dizi16[{i}][{j}]={dizi16[i][j]}"); //$ ile yazdıldığında da böyle oluyor...

            #endregion

            #region 3. Create Instanse

            //// int türünden 5 elemanlı "dizi17" isimli bir dizi yaratınız.

            //Array dizi17 = Arrays.CreatInstance(typeof(int), 5);
            
            //// int türünden 3x2x5 boyutunda 3 boyutlu dizi yaratımı
            //Array dizi18= Arrays.CreatInstance(typeof(int), 3,2,5);


            ////ilginç kullanım... yaratılırken ilk değerlerin atanması
            //int[] dizi19 = new int[5] { 2,3,4,5,6};

            //// Gerçekten ilginç

            //// dizi20 int ve 2x3x4x5x6 olarak 5 boyutlu hal aldı
            //Array dizi20 = P06_Arrays.CreateInstance(typeof(int), dizi19); //dinamik bir dizi yaratmış oldum. Yukarıdaki sayıları direkt dizi ismiyle ldım!!!


            #endregion

            #region 4. Dizi Kopyalama
            //int[] dizi22 = { 1, 2, 3, 4 };
            //int[] dizi23 = new int[10];

            //dizi22.CopyTo(dizi23, 3); //dizi22'nin tüm elemanları dizi23'e 3. indexten itibaren aktarılıyor/kopyalanıyor.

            ////*

            //int[] dizi24 = { 1, 2, 3, 4 };
            //int[] dizi25= new int[10];

            //Arrays.CopyTo(dizi25, 3); // Kopyalama işlemi normalde 0. indexten başlar. Burada 3 tane eleman dizi24 -> dizi25 e kopyalanıyor. 

            #endregion

            #region 5. Dizi Sıralama

            Array sehirler = Array.CreateInstance(typeof(string), 8);

            sehirler.SetValue("İstanbul", 0);
            sehirler.SetValue("Ankara", 1);
            sehirler.SetValue("İzmir", 2);
            sehirler.SetValue("Bursa", 3);
            sehirler.SetValue("Adıyaman", 4);
            sehirler.SetValue("Muğla", 5);
            sehirler.SetValue("Trabzon", 6);
            sehirler.SetValue("Rize", 7);

            Console.WriteLine("Sırasız halde dizi\n\n");

            foreach (string sehir in sehirler)
                Console.Write(sehir + "  ");

            Console.WriteLine("");

            Console.WriteLine("Alfabetik sıralı halde dizi (A-Z)\n\n");

            Arrays.Sort(sehirler);

            foreach (string sehir in sehirler)
                Console.Write(sehir + "  ");

            Console.WriteLine("");
            Console.WriteLine("Alfabetik sıralı halde dizi (Z-A)\n\n");

            Arrays.Reverse(sehirler);
            
            foreach (string sehir in sehirler)
                Console.Write(sehir + "  ");






            #endregion



            Console.ReadKey();
        }
    }
}