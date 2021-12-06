using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.");
            Console.Write("A=");
            int a = Convert.ToInt32(Console.ReadLine());
            int firstA = a;
            Console.Write("B=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C=");
            int c = Convert.ToInt32(Console.ReadLine());
            int x = 0; // Счетчик количества размещенных квадратов
            while (a > c && b > c)
            {
                a -= c;
                ++x;
                if (a <= c && b > c)
                {
                    b -= c;
                    a = firstA;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Не одного вхождения квадрата в прямоугольник");
            }
            else
            {
                Console.WriteLine("Количество квадратов, размещенных на прямоугольнике равно {0}", x);
            }

            Console.ReadKey();
        }
    }
}
