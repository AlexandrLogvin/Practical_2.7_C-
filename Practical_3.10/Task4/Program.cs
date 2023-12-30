// Задание 4. Наименьший элемент в последовательности

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну последовательности: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int n = int.MaxValue;

            for (int i = 1; i <= lenght; i++) 
            {
                Console.WriteLine($"Введите {i} число последовательности: ");
                int m = Convert.ToInt32(Console.ReadLine());
                if (m < n)
                {
                    n = m;
                }
            }
            Console.WriteLine($"Наименьший элемент в последовательности: {n}"); 
            Console.ReadKey();
        }  
            

    }
}
