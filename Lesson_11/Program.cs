using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRef ob1 = new MyRef(5, 6);
            MyRef ob2 = new MyRef(8, 9);

            Console.Write($"Переменные объекта ob1: ");
            ob1.Show();
            Console.Write($"Переменные объекта ob2: ");
            ob2.Show();

            if (ob1.SameAs(ob2))
            {
                Console.WriteLine($"ob1 и ob2 имеют одинаковые значения");
            }
            else
            {
                Console.WriteLine($"ob1 и ob2 имеют разные значения");
            }
            Console.WriteLine();

            ob1.Copy(ob2);
            Console.Write("ob1 после копиравания: ");
            ob1.Show();


            if (ob1.SameAs(ob2))
            {
                Console.WriteLine($"ob1 и ob2 имеют одинаковые значения");
            }
            else
            {
                Console.WriteLine($"ob1 и ob2 имеют разные значения");
            }


            Console.ReadKey();
        }
    }
}

// Класс MyRef - работа с передачи объектов методам по ссылке
class MyRef
{
    int Alfa, Beta;

    public MyRef(int a, int b)
    {
        Alfa = a;
        Beta = b;
    }
    public bool SameAs(MyRef ob)
    {
        if ((ob.Alfa == Alfa) & (ob.Beta == Beta))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Copy(MyRef ob)
    {
        Alfa = ob.Alfa;
        Beta = ob.Beta;
    }
    public void Show()
    {
        Console.WriteLine($"Alfa: {Alfa} | Beta: {Beta}");
    }


}






