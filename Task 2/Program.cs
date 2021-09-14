using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Эта программа создана для подсчета суммы нечетных положительных числел");
            Console.WriteLine("Для завершения программы нажмите ноль.");
            Console.WriteLine();
            int n;
            int count = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n > 0 && n % 2 != 0)
                    {
                        count = count + n;
                    }
                    else if (n == 0)
                    {
                        break;
                    }
                }
                else
                {

                    Console.WriteLine("Вы ввели некорректное значение.\nПовторите попытку ввода! ");
                }

            }

            Console.WriteLine($"Сумма нечетных положительных чисел - {count}");

            Console.ReadKey();
        }
    }
}
