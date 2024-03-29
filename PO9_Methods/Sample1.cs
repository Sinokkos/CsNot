﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO9_Methods
{
    internal class Sample1
    {
        public static void Main(string[] args)
        {

            // Hack 01
            // Dikdörtgen alanını hesaplayan bir metodun 4 farklı şeklinin incelenmesi


            #region 1. Geriye değer döndürmeyen ve parametre almayan metot

            //Hesapla();


            #endregion

            #region 2. Geriye değer döndürmeyen ve parametre alan
            // Kullanıcı girişi gibi işlemler burada
            // hesap kitap metotda olacak .... dolayısıyla buradan almış olduğum bilgileri parametre olarak göndereceğim


            //Console.WriteLine("Lütfen kısa kenarı giriniz :");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen uzun kenarı giriniz :");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //Hesapla(kk, uk);

            #endregion

            #region 3. Geriye değer döndüren ve parametre almayan metot

            //int sonuc = HesaplaPrmsiz();

            //Console.WriteLine($"\nDikdörtgenin alanı = {sonuc}");

            #endregion

            #region 4. Geriye değer döndüren ve parametre alan metot

            //Console.WriteLine("Lütfen kısa kenarı giriniz :");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen uzun kenarı giriniz :");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //// int sonuc1 = HesaplaPrmli(kk, uk);

            //Console.WriteLine($"\nDikdörtgenin alanı = {HesaplaPrmli(kk, uk)}");


            #endregion

            #region Hack 02
            // Uygun metot yapısına göre en uygun göreceğiniz yapıya göre
            // ekrandan alınacak 2 sayı için 4 (+,-,*,/) işlemi gerçekleştirecek pp
            // gerekiyorsa birden fazla metot da yazabilirsiniz.
            // Hint : işlem tipi diye bir değişkende tutarak hangi işlemin istendiğini ve ona göre çalışmasını sağlayabilirsiniz

            Console.WriteLine( "Lütfen 1. sayıyı giriniz :");
            int sayi1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nİşlem türü (+,-,*,/) :");
            string secenek= Console.ReadLine();

            int sonuc=DortIslem(sayi1 , sayi2,secenek);

            Console.WriteLine($" Yapmak istediğiniz {secenek} işleminin sonucu : {sonuc}");

            #endregion

            Console.ReadKey();


        }

        #region Methodlar

        // region 1 geri yok prmsiz
        private static void Hesapla()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");


        }

        //region 2 geri yok prmli
        private static void Hesapla(int pkisakenar, int puzunkenar)
        {
            int alan = pkisakenar * puzunkenar;
            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");
        }


        // region 3 geri var prmsiz
        private static int HesaplaPrmsiz()
        {
            // geriye değer döndüren metotlarda mutlaka return keyword ü olmalıdır
            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            return alan;
        }


        // region 4 geri var prmli
        private static int HesaplaPrmli(int kisak, int uzunk)
        {
           return kisak*uzunk; 

        }

        // region Hack02
        private static int DortIslem(int psayi1, int psayi2, string psecenek) 
        {
            // bütün iş burada dönecek
            int sonuc=0;
            switch (psecenek)
            {
                case "+":
                    sonuc=psayi1 + psayi2;
                    break;

                case "-":
                    sonuc= psayi1 - psayi2; 
                    break;

                case "*":
                     sonuc= psayi1 * psayi2;
                    break;
                case "/":
                    // ya sayi2 yi sıfır girerse
                    try
                    {
                        sonuc=psayi1 / psayi2;
                    }
                    catch 
                    {
                        Console.WriteLine("sayı2 değeri 0...Lütfen düzgün değer giriniz.<çatık kaş>.");
                        
                    }
                     
                    break;

                default:
                    Console.WriteLine("Lütfen doğru işlem kodu giriniz...");
                    break;


            }



            return sonuc;


        }
          
        
        
         #endregion

    }

}
