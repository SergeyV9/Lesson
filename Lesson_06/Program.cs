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
            //int i;

            //for (i = 1; i < 10; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine("переменная i равна нулю");
            //            break;
            //        case 1:
            //            Console.WriteLine("переменная i равна одному");
            //            break;
            //        case 2:
            //            Console.WriteLine("переменная i равна двум");
            //            break;
            //        case 3:
            //            Console.WriteLine("переменная i равна трем");
            //            break;
            //        case 4:
            //            Console.WriteLine("переменная i равна четырем");
            //            break;
            //        case 5:
            //            Console.WriteLine("переменная i равна пяти");
            //            break;
            //        default:
            //            Console.WriteLine("переменная i больше пяти");
            //            break;
            //    }
            //}
            #endregion

            #region Цикл for

            //int i;
            //int k;

            //for (i = -10, k = 10; i <= k || i > k; i++, k--)
            //{
            //    Console.WriteLine($"Пременная i - {i} \t Преременная k - {k}");

            //    if (i == -1)
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region Цикл While

            //int num1, num2, sumL = 0, startL;

            //Console.Write("Введите первое число: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //startL = num1;

            //while (num1<num2)
            //{
            //    sumL += num1++;
            //}

            //Console.WriteLine($"Сумма {num2 - startL} чисел от {startL} до {num2} равна {sumL}");

            #endregion

            #region цикл Do While

            int num, nextdigit;
            string rez, nextrot;

            found1:
            Console.WriteLine("Инвертировать число?  y / n");
            nextrot = Console.ReadLine();

            found2:
            switch (nextrot)
            {
                case "y":

                    rez = "";
                    Console.WriteLine();
                    Console.Write("Введите число: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        nextdigit = num % 10;
                        rez += Convert.ToString(nextdigit);
                        num /= 10;

                    } while (num > 0);

                    Console.WriteLine($"результат равен - {rez}");

                    Console.WriteLine();
                    Console.WriteLine("Повторить?  y / n");
                    nextrot = Console.ReadLine();

                    if (nextrot == "y")
                    {
                        goto found2;
                    }
                    else if (nextrot == "n")
                    {
                        Console.WriteLine("Спасибо, что вользовались нашей программой!");
                        break;
                    }
                    else
                    {
                        goto default;
                    }

                case "n":

                    Console.WriteLine("Может в следующий раз.");
                    break;

                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    goto found1;
            }

            #endregion


            Console.ReadKey();
        }
    }
}
