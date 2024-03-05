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
            Console.WriteLine($"Yuvarlama 1 - {Math.Round(0.5)}\n\n"); // . dan sonra gelen sayı 5 <= ise alt sayıya yuvarlanır.
            Console.WriteLine($"Yuvarlama 2 - {Math.Round(3.01)}\n\n");
            Console.WriteLine($"Yuvarlama 3 - {Math.Round(3.49)}\n\n");
            Console.WriteLine($"Yuvarlama 4 - {Math.Round(3.51)}\n\n");
            Console.WriteLine($"Yuvarlama 5 - {Math.Round(3.50)}\n\n"); // . dan sonra gelen sayı 5 <= ise alt sayıya artarak yuvarlanır 
                                                                        // Bu örnekte 0 kendini bir arttırarak 5'e eklenirse 6 değeri bizi üst sayıya yuvarlar.
        }
    }
}
