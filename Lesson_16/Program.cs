using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // использование рекурсивного метода.

            string a = "Это текст";
            RevStr rev = new RevStr();

            Console.WriteLine($"Исходная строка: {a}");

            Console.Write("Cтрока в обратном порядке: ");
            rev.DispStr(a);

            Console.ReadKey();

        }

        class RevStr
        {
            public void DispStr(string str)
            {
                if (str.Length > 0)
                {
                    DispStr(str.Substring(1, str.Length - 1));
                }
                else
                {
                    return;
                }

                Console.Write(str[0]);
            }
        }
    }
}
