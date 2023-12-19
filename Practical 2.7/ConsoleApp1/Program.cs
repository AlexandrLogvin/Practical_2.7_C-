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
            string fullName = "Пушкин Александр Сергеевич";
            int age = 224;
            string email = "apushkin@mail.com";
            float pointProg = 10;
            float pointMath = 8;
            float pointPhis = 6;

            Console.WriteLine($"Ф.И.О:{fullName,50} \nВозраст:{age,48} \nemail:{email,50} \nБаллы по програмированию:{pointProg,31}" +
                $" \nБаллы по математике:{pointMath,36} \nБаллы по физике: {pointPhis,39}");
            
            Console.ReadKey();

            float summPoint = 0;
            float averagePoint = 0;

            summPoint = pointProg + pointMath + pointPhis;  //Сумма баллов

            averagePoint = summPoint / 3;                   //Средний балл


            Console.WriteLine($"\nСредний балл: {averagePoint}"); 
            Console.ReadKey();
        }
    }

        

}


