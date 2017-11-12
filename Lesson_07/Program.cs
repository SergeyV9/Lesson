using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07
{

    class Program
    {
        static void Main(string[] args)
        {
            #region использование класса Building.

            Buiding House = new Buiding(2, 2500, 4);

            //House.Occupants = 4;
            //House.Area = 2500;
            //House.Floors = 2;

            Console.WriteLine($"дом имеет: \n" +
                $"{House.Floors} этажей \n" +
                $"{House.Occupants} жильцов \n" +
                $"Общей площадью {House.Area} кв/м из них: \n" +
                $"На одного человека приходится - {House.PersonArea()}\n" +
                $"В доме модет проживать - {House.MaxOccupants(300)} человек");

            #endregion

            #region использование класса ChkNum.

            Console.WriteLine("\n\n\n");

            ChkNum Ob = new ChkNum();

            for (int i = 2; i < 10; i++)
            {
                if (Ob.IsPraim(i)) Console.WriteLine($"{i} - простое число");
                else Console.WriteLine($"{i} - является не простым числом");
            }

            #endregion

            Console.ReadKey();
        }
    }

    class Buiding // Класс Building
    {
        public int Floors; // Количество этажей.
        public int Area; // Общая площадь здания.
        public int Occupants; // Количество жильцов.

        public Buiding(int f, int a, int o)
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        public int PersonArea()
        {
            return Area / Occupants;
        }
        public int MaxOccupants(int MinArea)
        {
            return Area / MinArea;
        }
    }

    class ChkNum // Класс ChkNum
    {
        public bool IsPraim(int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0) return false;
            }
            return true;
        }
    }

}
