// Задание 2. Сложение матриц

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[n, m];
            int[,] matrix2 = new int[n, m];
            int[,] matrixSumm = new int[n, m];

            Random r = new Random();

            Console.WriteLine("\nПервая матрица:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = r.Next(10);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВторая матрица:\n");    
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix2[i, j] = r.Next(10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма двух матриц:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixSumm[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{matrixSumm[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
