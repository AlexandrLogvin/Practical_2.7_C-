// Задание 5. Игра «Угадай число»

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра угадай число\n");
            Console.WriteLine("Введите максимальное число диапазона:");
            int nmax = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int inum = rand.Next(1, nmax);
            int userNumber;
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nВведите ваше число: ");
                count++;
                string innumber = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(innumber))
                {
                    Console.WriteLine($"Загаданное число {inum}");
                    Console.ReadKey();
                    break;
                }
                
                userNumber = Convert.ToInt32(innumber);
                if (userNumber < inum)
                {
                    Console.WriteLine("Введеное число меньше загаданного");
                }
                else if (userNumber > inum)
                {
                    Console.WriteLine("Введеное число больше загаданного");
                }
                else if (userNumber == inum) 
                {
                    Console.WriteLine($"\n\n\n\nЧисло {inum} угадано c {count} попытки!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
