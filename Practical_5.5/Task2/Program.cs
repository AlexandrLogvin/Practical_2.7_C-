// Задание 2. Перестановка слов в предложении

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
            Console.WriteLine("Введите предложение: ");
            string inputPhrase = Console.ReadLine();

            string resultPhrase = Reverse(inputPhrase);

            Console.WriteLine(resultPhrase);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод реализующий обратный порядок слов
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static string Reverse(string inputPhrase)
        { 
           string[] arrWords = SplitText(inputPhrase);

            string reversedPhrase = "";

            for (int i = arrWords.Length - 1; i >= 0; i--)
            {
                reversedPhrase += arrWords[i] + " ";
            }
            return reversedPhrase;

        }

        /// <summary>
        /// Метод разделения предложения на отдельные слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] arrayWords = text.Split(' ');
            return arrayWords;
        }
    }
}
