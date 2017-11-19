using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Обратная величина числа 5: {NumFn.Reciprocal(5.0)}");
            Console.WriteLine($"Дробная часть числа 4.1457: {NumFn.FracPart(4.1457)}");

            if (NumFn.IsEven(10))
            {
                Console.WriteLine("Число 10 четное");
            }

            if (NumFn.IsOdd(5))
            {
                Console.WriteLine("Число 5 нечетное");
            }
            // NumFn ob = new NumFn(); // Не возможно создать экземпляр статического класса.
            Console.ReadKey();
        }


        static class NumFn
        {
            // Возвратить обратное числовое значение.
            static public double Reciprocal(double num)
            {
                return 1 / num;
            }
            // Возвратить дробную часть числа.
            static public double FracPart(double num)
            {
                return num - (int)num;
            }
            // Возвратить истина если число четное.
            static public bool IsEven(double num)
            {
                return (num % 2) == 0 ? true : false;
            }
            // Возвратить истина если число нечетное.
            static public bool IsOdd(double num)
            {
                return !IsEven(num);
            }





        }
    }
}
