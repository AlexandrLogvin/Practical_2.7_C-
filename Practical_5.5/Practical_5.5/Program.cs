// Задание 1. Метод разделения строки на слова

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = (Console.ReadLine());

            string[] arrWords = SplitText(text);

            WriteWords(arrWords);
        }

        /// <summary>
        /// Метод разделения предложения на отдельные слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] arrWords = text.Split(' ');
            return arrWords; 
        }

        /// <summary>
        /// Метод вывода массива в консоль
        /// </summary>
        /// <param name="arrWords"></param>
        static void WriteWords(string[] arrWords)
        {
            foreach (var sub in arrWords)
            {
                Console.WriteLine(sub);
            }
            Console.ReadKey();
        }
    }
}
