using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArgDemo arg = new ArgDemo();

            // использование именнованных аргументов.
            if (arg.IsFactor(10,2))
            {
                Console.WriteLine("2 множитель 10");
            }
            if(arg.IsFactor(55, divisor: 5))
            {
                Console.WriteLine("5 множитель 55");
            }
            //if(arg.IsFactor(val: 33, 3))
            //{
            //    Console.WriteLine("3 множитель 33");
            //}
            if(arg.IsFactor(val: 88, divisor: 2))
            {
                Console.WriteLine("2 множитель 88");
            }
            if (arg.IsFactor(divisor: 2, val: 88))
            {
                Console.WriteLine("2 множитель 88 оборатный порядок параметров");
            }

            Console.ReadKey();
        }


        class ArgDemo
        {
            public bool IsFactor(int val, int divisor)
            {
                if (val % divisor == 0) return true;
                return false;
            }
        }
    }
}
