using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    internal class MathFunctionsWork
    {
        public static void Main(string[] args)
        {

            #region 1. Sayı Yuvarlama (Round)


            //Console.WriteLine($"Yuvarlama 2 - {Math.Round(0.5)}\n\n");   // . dan sonra gelen sayı 5 <= ise alt sayıya yuvarlanır.
            //Console.WriteLine($"Yuvarlama 2 - {Math.Round(3.01)}\n\n");
            //Console.WriteLine($"Yuvarlama 3 - {Math.Round(3.49)}\n\n");
            //Console.WriteLine($"Yuvarlama 4 - {Math.Round(3.51)}\n\n");
            //Console.WriteLine($"Yuvarlama 5 - {Math.Round(3.50)}\n\n"); // . dan sonra gelen sayı 5 <= ise alt sayıya artarak yuvarlanır 
            //                                                            // Bu örnekte 0 kendini bir arttırarak 5'e eklenirse 6 değeri bizi üst sayıya yuvarlar.
            #endregion

            #region 2. Vücut Kitle Endex hesaplama örneği

            //double kilo = 62.3;
            //double boy = 1.58;
            //double vke;

            //vke = kilo / (boy * boy);

            //Console.WriteLine("Vücut Kilo Endexi Hesaplama (VKE)");
            //Console.WriteLine($"Kilo: {kilo}kg");
            //Console.WriteLine($"Boy : {boy}m");
            //Console.WriteLine($"VKE: {vke: 0.#}");



            #endregion

            #region 3. String Örnekleri

            string isim = "Sinem";
            string selamlama = $"Selam {isim}!";

            Console.WriteLine(selamlama);



            #endregion



            Console.ReadKey();
        }
    }
}
