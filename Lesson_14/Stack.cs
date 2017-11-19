using System;

namespace Lesson_14
{
    partial class Program
    {
        class Stack
        {
            char[] stck;
            int tos;

            public Stack(int size)
            {
                stck = new char[size];
                tos = 0;
            }
            public Stack(Stack ob)
            {
                stck = new char[ob.stck.Length];
                for (int i = 0; i < ob.tos; i++)
                {
                    stck[i] = ob.stck[i];
                    tos = ob.tos;
                }
            }
            public void Push(char ch) // поместить символы в стек.
            {
                if (tos==stck.Length)
                {
                    Console.WriteLine("- Стек заполнен");
                    return;
                }
                stck[tos] = ch;
                tos++;
            }
            public char Pop() // извлечь символы из стека.
            {
                if (tos == 0)
                {
                    Console.WriteLine("- Стек пуст.");
                    return (char)0;
                }
                tos--;
                return stck[tos];
            }
            public bool IsFull()
            {
                return tos == stck.Length;
            }
            public bool IsEmpty()
            {
                return tos == 0;
            }
            public int Capasity()
            {
                return stck.Length;
            }
            public int GetNum()
            {
                return tos;
            }

        }
    }
}
