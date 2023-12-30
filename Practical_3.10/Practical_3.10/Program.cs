// Задание 1. Приложение по определению чётного или нечётного числа

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) 
            {
                Console.WriteLine("Число четное");
                Console.ReadKey(); 

            }
            else
            {
                Console.WriteLine("Число нечетное");
                Console.ReadKey();
            }

        }
    }
}
