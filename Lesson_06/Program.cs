using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Оператор выбора if else
            //int num;

            //for (num = 2; num < 20; num++)
            //{
            //    if ((num % 2) == 0)
            //        Console.WriteLine($"наименьший множитель числа {num} равен 2.");
            //    else if ((num % 3) == 0)
            //        Console.WriteLine($"наименьший множитель числа {num} равен 3.");
            //    else if ((num % 5) == 0)
            //        Console.WriteLine($"наименьший множитель числа {num} равен 5.");
            //    else if ((num % 7) == 0)
            //        Console.WriteLine($"наименьший множитель числа {num} равен 7.");
            //    else Console.WriteLine($"{num} не делится на 2, 3, 5 или 7.");
            //} 
            #endregion



            #region Оператор выбора Switch case
            int i;

            for (i = 1; i < 100; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("переменная i равна нулю");
                        break;
                    case 1:
                        Console.WriteLine("переменная i равна одному");
                        break;
                    case 2:
                        Console.WriteLine("переменная i равна двум");
                        break;
                    case 3:
                        Console.WriteLine("переменная i равна трем");
                        break;
                    case 4:
                        Console.WriteLine("переменная i равна четырем");
                        break;
                    case 5:
                        Console.WriteLine("переменная i равна пяти");
                        break;
                    default:
                        Console.WriteLine("переменная i больше пяти");
                        break;
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
