using System;

namespace Lesson_14
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Char ch;
            int i;

            Console.WriteLine("Поместить в стек символы от A до J");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char)('A' + i));
            }

            Stack stk2 = new Stack(stk1);

            Console.Write("Содержимое stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            Console.WriteLine();

            Console.Write("Содержимое stk2: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
            Console.WriteLine("\n");




            Console.ReadKey();
        }
    }
}
