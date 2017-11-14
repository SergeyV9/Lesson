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
