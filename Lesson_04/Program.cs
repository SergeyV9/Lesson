using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double S1 = 10.46;
            double S2 = 4.59;

            double Gipot = Math.Sqrt(Math.Pow(S1, 2) + Math.Pow(S2, 2)); // Инициализация переменной выражением.

            Console.WriteLine($"Гипотинуза со сторонами {S1} и {S2} равна {Gipot:#.###}\n");

            byte b = 10;
            byte c;

            c = (byte)(b + b); // продвижение до int, поэтому необходимо явное приведение к byte

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
