using System;
using System.IO;


namespace Practical_6._6
{
    internal class Program
    {
        private static string filePath = @"C:\employees.txt"; // Путь к файлу

        static void Main(string[] args)
        {
            Console.WriteLine("введите 1 — вывести данные на экран;\nвведите 2 — заполнить данные и добавить новую запись в конец файла.");
            byte inputNumber = Convert.ToByte(Console.ReadLine());

            if (inputNumber == 1) 
            {
                ReadingFromFile(filePath);
            }
            else if(inputNumber == 2) 
            {
                AddEmployees();
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }

        /// <summary>
        /// Чтение данных из файла
        /// </summary>
        /// <param name="filePath"></param>
        private static void ReadingFromFile(string filePath)
        {
            if(File.Exists(filePath))
            {
                string[] fileText = File.ReadAllLines(filePath);

                foreach (string line in fileText)
                {
                    string[] parts = line.Split('#');
                    Console.WriteLine($"{parts[0]} {parts[1]} {parts[2]} {parts[3]} {parts[4]} {parts[5]} {parts[6]}");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Файл еще не создан");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Добавление нового сотрудника
        /// </summary>
        private static void AddEmployees()
        {
            var inputData = DataInput();
            WriteToFile(inputData.IdNumber, inputData.DataNow, inputData.FullName, inputData.Age, inputData.Height, inputData.BirthDate, inputData.BirthPlace);

            Console.WriteLine("\nДанные записаны в файл.");
            Console.ReadKey();
        }

        /// <summary>
        /// Ввод данных нового сотрудника
        /// </summary>
        /// <returns></returns>
        private static (int IdNumber, DateTime DataNow, string FullName, int Age, double Height, DateTime BirthDate, string BirthPlace) DataInput()
        {
            int idNumber = DefineId(filePath);
            Console.WriteLine($"ID сотрудника: {idNumber}");

            DateTime dataNow = DateTime.Now;

            Console.WriteLine("Введите Ф.И.О.: ");
            string fullName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите дату рождения в формате (гггг-мм-дд): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите место рождения: ");
            string birthPlace = Convert.ToString(Console.ReadLine());

            return(idNumber, dataNow, fullName, age, height, BirthDate, birthPlace);
        }

        /// <summary>
        /// Определение id нового сотрудника
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static int DefineId(string filePath)
        {
            if (File.Exists(filePath))
            {
                int idNextNumber = File.ReadAllLines(filePath).Length + 1;
                return idNextNumber;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Запись введенных данных в файл
        /// </summary>
        /// <param name="idNumber"></param>
        /// <param name="dataNow"></param>
        /// <param name="fullName"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="birthDate"></param>
        /// <param name="birthPlace"></param>
        private static void WriteToFile(int idNumber, DateTime dataNow, string fullName, int age, double height, DateTime birthDate, string birthPlace)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{idNumber}#{dataNow:dd.MM.yyyy HH:mm}#{fullName}#{age}#{height}#{birthDate:dd.MM.yyyy}#{birthPlace}");
            }
        }
    }
}
