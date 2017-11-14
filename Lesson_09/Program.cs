using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lesson_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Програмировать в .NET лучше всего в C#";
            string str2 = "Програмировать в .NET лучше всего в C#";
            string str3 = "Строки в C# весьма эфективны";
            string strUp, strLow;
            int result, idx;

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"Длина строки str1 равна - {str1.Length}");

            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            strUp = str1.ToUpper(CultureInfo.CurrentUICulture);

            Console.WriteLine($"Строка str1 строчными - {strLow}");
            Console.WriteLine($"Строка str1 прописными - {strUp}");

            Console.WriteLine($"\n{new string('+', 70)}\n");

            foreach (char x in str1)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine($"\n\n{new string('+', 70)}\n");

            if (str1 == str2) Console.WriteLine("str1 равна str2");
            else Console.WriteLine("str1 Не равна str2");

            if (str2 == str3) Console.WriteLine("str2 равна str3");
            else Console.WriteLine("str2 Не равна str3");

            Console.WriteLine($"\n{new string('+', 70)}\n");

            str2 = "Новое значение для переменной";

            idx = str2.IndexOf("Новое", StringComparison.Ordinal);
            Console.WriteLine($"Найденое значение - {idx}");

            idx = str2.LastIndexOf("переменной", StringComparison.Ordinal);
            Console.WriteLine($"Индекс последнего вхождения строки \"переменной\" - {idx}");


            Console.ReadKey();
        }


    }
}
