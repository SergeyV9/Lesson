using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Число\tКвадрат\tКуб");

            //int i = new Int32(); // там на самом деле выглядит объявление переменной.
            int i; // это короткая форма объявления переменной.

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i); //старый способ подстановки данных
                Console.WriteLine($"{i}\t{i * i}\t{i * i * i:N2}"); //ноный способ подстановки данных
            }


            Console.ReadKey();
        }
    }
}
