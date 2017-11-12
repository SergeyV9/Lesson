using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region одномерный массив.

            int[] Semopl = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Semopl[i] = i * i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} элемент массива Semole равен {Semopl[i]}");
            }

            #endregion

            Console.WriteLine($"\n{new string('=', 40)}\n");

            #region Двухмерный массив.

            int j, k;

            int[,] table = new int[3, 4];

            for (j = 0; j < 3; j++)
            {
                for (k = 0; k < 4; k++)
                {
                    table[j, k] = (j * 4) + k + 1;
                    Console.Write(table[j, k] + " ");
                }
            }


            #endregion

            Console.WriteLine($"\n\n{new string('=', 40)}\n");

            #region Использование свойства массива Length

            int[] nums = new int[10];

            Console.WriteLine($"Длинная массива nums равна {nums.Length}");

            for (int i = 0; i < nums.Length; i++) nums[i] = i * i;

            Console.Write("Массив содержит: ");
            for (int i = 0; i < nums.Length; i++) Console.Write($"{nums[i]} ");
            {

            }

            #endregion

            Console.WriteLine($"\n\n{new string('=', 40)}\n");

            #region Многомерный массив

            int[][] NetworkNodes = new int[4][];
            NetworkNodes[0] = new int[3];
            NetworkNodes[1] = new int[7];
            NetworkNodes[2] = new int[2];
            NetworkNodes[3] = new int[5];

            int o, p;

            for (o = 0; o < NetworkNodes.Length; o++)
                for (p = 0; p < NetworkNodes[o].Length; p++)
                    NetworkNodes[o][p] = o * p + 70;
            Console.WriteLine($"Общее количество узлов сети {NetworkNodes.Length}\n");

            for (o = 0; o < NetworkNodes.Length; o++)
            {
                for (p = 0; p < NetworkNodes[o].Length; p++)
                {
                    Console.Write($"Использование в узле сети {o} ЦП {p} :");
                    Console.Write($"{NetworkNodes[o][p]} % ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            #endregion

            Console.WriteLine($"\n{new string('=', 40)}\n");

            #region Цикл foreach
            int SumF = 0;
            int[] NumF = new int[10];

            for (int i = 0; i < 10; i++) NumF[i] = (i+33)*i;

            foreach (int x in NumF)
            {
                Console.WriteLine($"Значение элемента равно {x}");
                SumF += x;
                if (x == 4) break;
            }
            Console.WriteLine(SumF/NumF.Length);

            #endregion

            Console.ReadKey();
        }
    }
}
