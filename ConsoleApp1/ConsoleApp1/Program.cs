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
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
           

            for (int i = 0; i < num1.Length; i++)
            {

                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == num2[j])
                    {
                        continue;
                    }
                   
                }
                 
                
                 Console.WriteLine($"Уникально число {num1[i]}");
                 Console.ReadKey();
                
            }
        }
    }
}
