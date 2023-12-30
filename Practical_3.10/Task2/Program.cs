// Задание 2. Программа подсчёта суммы карт в игре «21»

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру 21!");
            Console.WriteLine("Сколько карт у вас на руках?");
            int n = Convert.ToInt32(Console.ReadLine()); // Число карт
            int summ = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите номинал {i} карты");
               
                string nominal = Console.ReadLine();

                switch (nominal)
                {
                    case "6":
                        summ = summ + 6;
                        break;
                    case "7":
                        summ = summ + 7;
                        break;
                    case "8":
                        summ = summ + 8;
                        break;
                    case "9":
                        summ = summ + 9;
                        break;
                    case "10":
                        summ = summ + 10;
                        break;
                    case "T":
                        summ = summ + 10;
                        break;
                    case "K":
                        summ = summ + 10;
                        break;
                    case "Q":
                        summ = summ + 10;
                        break;
                    case "J":
                        summ = summ + 10;
                        break;
                    default:
                        Console.WriteLine("Неверный номинал карты");
                        i--;
                        break;
                }
            }
             
            Console.WriteLine($"Сумма карт {summ}");
            Console.ReadKey(); 
                    
          
        }
    }
}
