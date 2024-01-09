// Задание 1. Случайная матрица

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Random r = new Random();

            int summ = 0;
            int summ_m = 0;

            for(int i = 0; i < n; i++)
            {
                summ += summ_m;

                for(int j = 0; j < m; j++) 
                {
                    matrix[i, j] = r.Next(10);
                    summ_m += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                summ = summ_m;
                Console.WriteLine();
            }
            Console.WriteLine($"\nСумма всех элементов матрицы: {summ}");
            Console.ReadKey();
        }
    }
}
