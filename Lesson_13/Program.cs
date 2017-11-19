using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Работа с классом Min.
            Console.WriteLine($"\n{new string('=', 60)} Работа с классом Min\n");

            Min min = new Min();

            int rezmin, a = 10, b = 20;

            rezmin = min.MinVal(a, b);
            Console.WriteLine($"Минимальное значение из a и b: {rezmin}");

            rezmin = min.MinVal(a, b, 1, 22, 5);
            Console.WriteLine($"Минимальное значение: {rezmin}");

            int[] arrea = { 10, 20, 5, 9, 4, 1, 6, 8, -1 };
            rezmin = min.MinVal(arrea);
            Console.WriteLine($"Минимальное значение из массива: {rezmin}");

            #endregion

            Console.WriteLine($"\n{new string('=', 60)} Работа с классом MyClass\n");

            #region Работа с классом MyClass.

            MyClass ob = new MyClass();

            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass an_ob = ob.Factory(i, j);
                an_ob.Show();
            }


            #endregion

            Console.WriteLine($"\n{new string('=', 60)} Работа с классом Factor\n");

            #region Работа с классом Factor

            Factor f = new Factor();
            int numfactors;
            int[] factors;

            factors = f.FindFactor(1000, out numfactors);

            Console.WriteLine("Множитель чиста 1000\n");

            for (int i = 0; i < numfactors; i++)
            {
                Console.Write(factors[i] + " ");
            }



            #endregion




            Console.ReadKey();
        }


        class Min
        {
            public int MinVal(params int[] nums)
            {
                int m;

                if (nums.Length == 0)
                {
                    Console.WriteLine();
                    return 0;
                }

                m = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < m) m = nums[i];
                }
                return m;
            }
        }

        class MyClass
        {
            int a, b;

            public MyClass Factory(int i, int j)
            {
                MyClass t = new MyClass();
                t.a = i;
                t.b = j;

                return t;
            }

            public void Show()
            {
                Console.WriteLine("Переменные А и B: " + a + " - " + b);
            }
        }

        class Factor
        {
            public int[] FindFactor(int num, out int numf)
            {
                int[] f = new int[80];
                int i, j;

                for (i = 2, j = 0; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        f[j] = i;
                        j++;
                    }
                }
                numf = j;
                return f;

            }
        }

    }
}
