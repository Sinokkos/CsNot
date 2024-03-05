using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO5_FlowMechanisms
{
    internal class ForSimple
    {
        public static void Main(string[] args)
        {
            // for(başlangıç; koşul;son)
            // {
            //    yapılacak işler
            //}


            #region 1. Kullanıcıdan alınan adet kadar ekrana "Merhaba Dünya" yazdırınız... 
            // Aralarında bir satır da boşluk olsun

            //int adet= 0;

            //Console.WriteLine("Lütfen mesaj yazdırılacak adet bilgisini giriniz  :");
            //adet = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= adet; i++) // koşul doğru olduğu sürece { } arasındaki işlemi yap
            //{
            //    Console.WriteLine("Merhaba Dünya.. Nasıl gidiyor?... Dark evrenine hoşgeldiniz...");
            //}


            #endregion

            #region 2. ekrandan alınacak 2 sayı arasındaki değerleri ekrana yazınız...
            //int sayi1, sayi2;

            //Console.WriteLine("Lütfen 1. sayı :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayı :");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    Console.WriteLine("Sayı -" + i.ToString() + "\n\n");

            //}

            Console.ReadKey();

            #endregion


            #region 3. girilen iki sayı arasının toplamını veren programı yazınız. Sonuçta toplam gözüksün

            //int sayi1, sayi2, toplam;

            //Console.WriteLine("Lütfen 1. sayı :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayı :");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //toplam = 0;


            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine("Toplam - " + toplam.ToString() + "\n");



            #endregion


            #region 4. Kullanıcının girdiği 2 sayının çarpma işlemini toplama kullanarak bulunuz ve yazınız.

            //int sayi1, sayi2, sonuc;

            //Console.WriteLine("Lütfen 1. sayı :");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayı :");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //sonuc = 0;


            //for (int i = 0; i < sayi1; i++)
            //{
            //    sonuc = sonuc + sayi2;
            //}

            //Console.WriteLine("Çarpım sonucu - " + sonuc.ToString() + "\n");



            #endregion

            #region 5. Kullanıcıdan 10 6 adet sayı alınacak.(-,+) Çıkışta istenen durum...
            // negatiflerin toplamını ayrı 
            // pozitiflerin toplamını ayrı göster
            // Örnek: Negatif sayıların toplamı = -24
            //        Pozitif sayıların toplamı = 55

            //int sayi; // ekrandan alınacak değer 

            //int ptoplam= 0; //pozitiflerin toplamını tutacak
            //int ntoplam= 0; // negatiflerin toplamını tutacak

            //for (int sayac = 1; sayac <= 6; sayac++)
            //{
            //    Console.WriteLine("Lütfen" + sayac.ToString() + ".sayınızı giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());

            //    if (sayi > 0)
            //    {
            //        ptoplam += sayi; // sayı pozitifse ptoplama ekliyorum
            //    }
            //    else
            //    {
            //        ntoplam += sayi; // sayı negatifse ntoplama ekliyorum
            //    }

            //}


            //Console.WriteLine($"Pozitif sayıların toplamı = {ptoplam} \n\n");
            //Console.WriteLine($"Negatif sayıların toplamı = {ntoplam} \n\n");


            #endregion

            Console.ReadKey();

        }

    }
}