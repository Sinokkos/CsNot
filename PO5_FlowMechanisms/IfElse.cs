using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO5_FlowMechanisms
{
    public static void Main(string[] args)
    {
        //if-else ..belirli bir koşul sağlandığında bu koşul uygun olan komutlar çalıştırılır.Koşul sağlanmıyorsa diğer komutlar çalıştırılır.

        //Syntax:

        // if (koşulumuz)
        //{
        //    doğru ise çalışacak kod bloğu
        // }
        //else
        //{
        //    yanlışsa çalışacak kod bloğu
        // }

        #region 1. Standart kullanım
        //int sayi1 = 5;
        //int sayi2 = 15;


        //if (sayi1 < sayi2)
        //{
        //    Console.WriteLine("Evet... sayi1 sayi2 den küçüktür....");
        //}
        //else
        //{
        //    Console.WriteLine("Hayır... sayi1 sayi2 den büyüktür....");

        //}
        #endregion

        #region 2. diğer bir kullanım şekli
        // her zaman else ifadesinin kullanılması şart değildir. 

        //int sayi11 = 12;
        //int sayi21 = 4;

        //if (sayi11 != sayi21)
        //{
        //    Console.WriteLine("Haklısın... eşit değil");
        //}
        ////....


        #endregion

        #region 3. şöyle bir kullanım

        //Console.WriteLine("Lütfen cinsiyet bilginizi giriniz (e/k): ");

        // ekrandan/klavyeden bilgi okuma yapılacak
        //char cins = Convert.ToChar(Console.ReadLine()); // ekrandan okuduğunu char türüne çevir demek istiyor. 
        //// normalde string yazılabilir fakat bellekten kazanmak için yapıyoruz.

        //if (cins == 'e') // kontrol
        //{
        //    Console.WriteLine("Cinsiyet : Erkek..");
        //}
        //else if (cins == 'k')
        //{
        //    Console.WriteLine("Cinsiyet : Kadın..");
        //}
        //else 
        //{ 
        //    Console.WriteLine("Lütfen doğru bilgi giriniz..."); 
        //}

        #endregion

        #region 4. Kullanıcı adı/şifre giriş kontrolü
        // ekrandan iki adet bilgi alacağım. Kullanıcı adı  ve şifre.(İkisi birden) Kendi tanımladığım değerlerle aynıysa "Sisteme hoşgeldini" diye mesaj çıksın ekrana. Değil ise bana hangi bilginin uygun olmadığını söylesin.

        //string benimkad = "admin"; // benim tanımladığım kullanıcı adı 
        //string benimsifre = "1234"; // şifre

        //string ekad; //ekrandan alınan kullanıcı adı
        //string esifre; // ekrandan alınan şifre

        //Console.WriteLine("Kullanıcı Adı :");
        //ekad = Console.ReadLine(); //ekrandan okuyup değişkene yerleştirdi

        //Console.WriteLine("Kullanıcı Şifre :");
        //esifre= Console.ReadLine(); //ekrandan okuyup değişkene yerleştirdi

        //if (ekad == benimkad)
        //{
        //    if (esifre == benimsifre)
        //    {
        //        Console.WriteLine("Sisteme Hoşgeldiniz...İyi çalışmalar...");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen bilgi doğru değil. Lütfen kontrol ediniz...");// hackerlar için önlem. Acaba şifre mi yanlış kullanıcı adı mı?
        //    }

        //}
        //else
        //{
        //    Console.WriteLine("Girilen bilgi doğru değil. Lütfen kontrol ediniz..."); // hackerlar için önlem. Acaba şifre mi yanlış kullanıcı adı mı?
        //}

        #endregion

        #region 5. Problem Çalışması 
        //2 sayıdan büyük olanı bulmak. Ekrandan girilecek olan sayılar var...

        // readline string okuduğu için bunu sayıya çevirmek için .ToInt32 kullanın

        //int sayi1; //ekrandan alacağım bilgiyi tutacak
        //int sayi2; // ekrandan alacağım bilgiyi tutacak


        //Console.WriteLine("Lütfen 1. sayınızı giriniz : ");
        //sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lütfen 2. sayınızı giriniz : ");
        //sayi2 = Convert.ToInt32(Console.ReadLine());

        //if (sayi1 > sayi2)
        //{
        //    Console.WriteLine("Evet sayı 1 sayı 2 den büyüktür...");
        //}
        //else if (sayi2 > sayi1)
        //{
        //    Console.WriteLine("Hayır sayı 2 sayı 1 den küçüktür...");

        //}
        //else
        //{
        //    Console.WriteLine("İki sayı da birbirine eşittir...."  );
        //}

        #endregion

        #region 6. Daily Workout !
        //3 sayıdan büyük olanı bulmak. Ekrandan girilecek olan sayılar var...
        // En baştaki sayıdan başla. 

        //int sayi1;
        //int sayi2;
        //int sayi3;
        //int enb;


        //Console.WriteLine("Lütfen 1. sayınızı giriniz :");
        //sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lütfen 2. sayınızı giriniz :");
        //sayi2 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lütfen 3. sayınızı giriniz :");
        //sayi3 = Convert.ToInt32(Console.ReadLine());

        //enb = sayi1;

        //if (sayi2 >enb)
        //    enb = sayi2;
        //if (sayi3 >enb)
        //    enb = sayi3;

        //Console.WriteLine("En büyük Sayı : {0}", enb);


        //Console.ReadKey();

        #endregion


    }

}
}
