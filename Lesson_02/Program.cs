using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivar;
            double dvar;

            ivar = 100;
            dvar = 100.0;

            Console.WriteLine($"Исходние значение ivar = {ivar}");
            Console.WriteLine($"Исходние значение dvar = {dvar}");
            Console.WriteLine("");

            ivar = ivar / 3;
            dvar = dvar / 3;

            Console.WriteLine($"ivar после деления = {ivar}");
            Console.WriteLine($"dvar после деления = {dvar}");

            Console.ReadKey();

        }
    }
}
