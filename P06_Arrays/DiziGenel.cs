using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziGenel
    {
        public static void Main(string[] args)
        {

            #region 1. Dizi tanımlama, değer atama, kullanma

            //int[] sayilar = new int[20]; // 20 elemanlık sayılar isminde bir dizi tanımı
            //string[] names = new string[20]; // 20 elemanlık string dizi oluşturdumç İsmi de names

            // bir değer atamak istersem 

            //sayilar[5] = 30;

            //names[10] = "Sinem";
            //names[11] = "30";

            //Console.WriteLine("Sayısal dizi sayilar'ın 5. indexindeki değer {0}", sayilar[5]);

            //Console.WriteLine("Metinsel dizi names'in 10. indexindeki değer {0}", names[10]);

            //Console.WriteLine("Metinsel dizi names'in 11. indexindeki değer {0}", names[11]);

            //int sayi1 = sayilar[5];
            //int sayi2 = Convert.ToInt32 (names[11]);  




            //Console.WriteLine("Toplam {0}", sayi1 + sayi2);


            // Tanımlamalar şöyle de olabilir
            //string[] sayilarAlfa = { "Bir", "İki", "Üç", "Dört" }; // daha tanımlanırken initial değerlerin belirlenmesi

            //int[] sayilar2 = { 1, 2, 3, 4, 5 };
            //float[] sayilar3 = { 2f, 1.2f, 7f };

            // Fekat bu şekilde dizi tanımlamaları sadece diziyi ilk tanımlarken yapabiliriz.Örneğin aşağıdaki gibi bir kullanım hata verecektir.


            //int[] sayilar4;
            //sayilar4= {5, 7, 89, 98}; // satırı kesmeden tanımlama yapmalıyım.


            //Console.WriteLine("Lütfen 1-10 arası bir sayı giriniz...");
            //int boyut = Convert.ToInt32(Console.ReadLine());

            //int[] sayilar5 = new int[boyut]; // dinamik olarak yarattım

            //sayilar5[5] = 40;

            //Console.WriteLine(sayilar5[5]);

            //int[] sayilar6 = new int[10], sayilar7 = new int[20];


            // Verilen bir string diziyi ters sırala (sondan başa doğru) olacak şekilde sıralama

            string[] myUCC12Team = { "Başak", "Yapmur", "Metincan", "Ege", "Tuğkan", "Ender", "Enis", "Sinem", "Furkan", "Şevval" };

            //diziyle ilgili bir boyut bilgisi yok şuan.
            // o yüzden

            int elemansayisi = myUCC12Team.Length - 1; //-1'in nedeni dizi index bilgisinin 0 dan başlaması
            // düzden

            //Console.WriteLine("Düzenden\n\n");
            //for (int i= 0; i <= elemansayisi; i++) 
            //{
            //    Console.WriteLine($"Dizinin {i}. inci elemanı {myUCC12Team[i]} dır.. \n");
            //    Console.WriteLine($"Dizinin {i}. inci elemanı {myUCC12Team[i]} dır.. \n");
            //}



            //// tersten
            //Console.WriteLine("Tersten\n\n");

            //for (int index = elemansayisi; index >= 0; --index) 
            //{
            //    Console.WriteLine($"Dizinin {index}. inci elemanı {myUCC12Team[index]} dır.. \n");
            //}

            #endregion






            Console.ReadKey();


        }
    }
}
