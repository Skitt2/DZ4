using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            int negative = 0;
            int number;
            Console.WriteLine("Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. Последовательность потенциально не ограничена, окончанием последовательности служит число 0.");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
                if (positive == negative)
                {
                    Console.WriteLine("Больше положительных чисел равно числу отрицательных чисел {0} = {1}", positive, negative);
                    continue;
                }
                if (positive > negative)
                {
                    Console.WriteLine("Больше положительных чисел {0} > {1}", positive, negative);
                }
                else
                {
                    Console.WriteLine("Больше отрицательных чисел {1} > {0}", positive, negative);
                }
            } while (number != 0);
            Console.ReadKey();
        }
    }
}
