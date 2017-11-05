using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            int x, y; //груповое обьевление переменных. 

            x = 100;
            Console.WriteLine($"Значение переменной X = {x}");
            y = x / 5;
            Console.WriteLine($"Значение Y = x/5 = {y}");


            Console.ReadKey();
        }
    }
}
