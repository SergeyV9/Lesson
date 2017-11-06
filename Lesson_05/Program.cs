using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num;
            ushort i;

            #region приведение числа к четности.
            //for (i = 1; i <= 10; i++)
            //{
            //    num = i;
            //    Console.WriteLine($"num: {num}");

            //    num = (ushort)(num & 0xFFFE);

            //    Console.WriteLine($"num после сброса младшего разряда {num}\n");

            //} 
            #endregion

            for (i = 1; i <= 10; i++)
            {
                num = i;

                if ((num & 1) == 1)
                {
                    Console.WriteLine($"{num} - нечетное число");
                }
                else
                {
                    Console.WriteLine($"{num} - четное число");
                }

            }


            Console.ReadKey();

        }
    }
}
