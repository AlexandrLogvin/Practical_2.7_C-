// Задание 3. Проверка простого числа

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool a = false;
            int n = 2;

            while (number > n)
            {
                
                if (number % n == 0)
                {
                    a = true;
                    break;
                }
                n++;
            }

            if (a == true)
            {
                Console.WriteLine($"Число {number} не является простым");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {number} является простым");
                Console.ReadKey();
            }   


    }    }
}
