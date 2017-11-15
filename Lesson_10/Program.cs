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

            Console.WriteLine("Поместить в stk1 символы A-J");

            for (i = 0; !stk1.IsFuul(); i++)
            {
                stk1.Push((char)('A' + i));
            }
            if (stk1.IsFuul()) Console.WriteLine("\nСтек stk1 заполнен. \n");
            Console.Write("Содержимое stk1: ");
            while (stk1.IsEmty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }

            Console.WriteLine($"\n{new string('+', 70)}\n");




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
