using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N)");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            for (int i = 1; i <= n; i++)
            {
                n2 += i * 2 - 1;
                Console.WriteLine(n2);
            }
            Console.ReadKey();
        }
    }
}
