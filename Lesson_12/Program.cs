using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Работа с классом MyRef.
            Console.WriteLine($"\n{new string('=', 60)} работа с параметрами ref\n");

            Console.WriteLine($"\n{new string('=', 20)} входные значения {new string('=', 20)}\n");

            MyRef ob = new MyRef();
            int a = 10;
            int b = 5;
            string c = "55";

            Console.WriteLine($"Переменная \"а\" до вызва: {a} | тип переменной: {a.GetType()}");
            Console.WriteLine($"Переменная \"b\" до вызва: {b} | тип переменной: {b.GetType()}");
            Console.WriteLine($"Переменная \"c\" до вызва: {c} | тип переменной: {c.GetType()}");

            Console.WriteLine($"\n{new string('=', 20)} выходные значения {new string('=', 19)}\n");

            ob.Sqr(ref a);
            ob.Sqr(ref b);
            ob.Sqr(ref c);


            Console.WriteLine($"Переменная \"а\" после вызва метода класса: {a}");
            Console.WriteLine($"Переменная \"b\" после вызва метода класса: {b}");
            Console.WriteLine($"Переменная \"b\" после вызва метода класса: {c}");
            Console.WriteLine($"Значение переменной \"i\" внутри класса {ob.SqrOut()}");
            #endregion

            #region Работа с классом Decompose.
            Console.WriteLine($"\n{new string('=', 60)} работа с параметрами out\n");

            Decompose obd = new Decompose();

            int i;
            double f;

            i = obd.GetParts(10.25, out f);

            Console.WriteLine($"Целая часть числа {i}");
            Console.WriteLine($"Дробная часть числа {f}");

            obd.GetSam("55", out i);

            Console.WriteLine($"Результат работы метода GetSam: {i}");

            #endregion


            Console.ReadKey();
        }
    }


    class MyRef
    {
        int resalt;

        public void Sqr(ref int i)
        {
            i = i * i;
            resalt = i;
        }

        public void Sqr(ref string i)
        {
            i = i + i;
        }

        public int SqrOut()
        {
            return resalt;
        }
    }

    class Decompose
    {
        public int GetParts(double n, out double frac)
        {
            int whole;

            whole = (int)n;
            frac = n - whole;
            return whole;
        }
        public void GetSam(string n, out int rez)
        {
            int i = Convert.ToInt32(n);

            rez = i + i;
        }

    }


}
