using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;
            string hh;

            Console.WriteLine("Поместить в stk1 символы A-J");

            for (i = 0; !stk1.IsFuul(); i++)
            {
                stk1.Push((char)('A' + i));
            }
            if (stk1.IsFuul()) Console.WriteLine("\nСтек stk1 заполнен. \n");
            Console.Write("Содержимое stk1: ");
            while (!stk1.IsEmty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }

            Console.WriteLine($"\n\n{new string('+', 70)}\n");

            if (stk1.IsEmty()) Console.WriteLine("Стек stk1 пуст.\n");


            for (i = 0; !stk1.IsFuul(); i++)
            {
                stk1.Push((char)('A' + i));
            }

            Console.WriteLine("Извлечь элементы из stk1 и поместить их в stk2");


            for (i = 0; !stk2.IsFuul(); i++)
            {
                stk2.Push(stk1.Pop());
            }

            Console.Write("Содержимое стека stk2: ");

            while (!stk2.IsEmty())
            {
                Console.Write(stk2.Pop());
            }

            Console.WriteLine($"\n\n{new string('+', 70)}\n");

            for (i = 0; i < 5; i++)
            {
                stk3.Push((char)('A' + i));
            }

            hh = "";

            for (i = 0; i<5; i++)
            {
                hh += Convert.ToString(stk3.Pop());
            }

            Console.WriteLine($"Емкость стека stk3: {stk3.Capasity()}");
            Console.WriteLine($"Количество объектов в стеке stk3: {stk3.GetNum()} ({hh})");

            Console.ReadKey();
        }


        class Stack
        {
            char[] stck;
            int tos;

            // Конструктор класса
            public Stack(int size)
            {
                stck = new char[size];
                tos = 0;
            }
            //Поместить символы в стек
            public void Push(char ch)
            {
                if (tos == stck.Length)
                {
                    Console.WriteLine(" - стек заполнен.");
                    return;
                }
                stck[tos] = ch;
                tos++;
            }

            // Извлечь символы из стека.
            public char Pop()
            {
                if (tos == 0)
                {
                    Console.WriteLine(" - стек пуст.");
                    return (char)0;
                }
                tos--;
                return stck[tos];
            }

            // Возвращает истина если стек заполнен.
            public bool IsFuul()
            {
                return tos == stck.Length;
            }

            // Возвращает истина если стек пуст.
            public bool IsEmty()
            {
                return tos == 0;
            }

            // Возвращает полную емкость стека.
            public int Capasity()
            {
                return stck.Length;
            }

            // Возвращает количество элементов находящихся в данный момент в стеке.
            public int GetNum()
            {
                return tos;
            }





        }


    }
}
