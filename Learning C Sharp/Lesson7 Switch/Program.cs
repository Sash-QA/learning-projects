using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Switch
{
    internal class Program
    {
        static void Main(string[] args)

        /*
         *  Условный оператор switch
         */

        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:                                         // Каждый кейс для удобства можно заключать в фигурные скобки, но это необязательно
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Вы ввели число 3 или 4");
                    break;
                default:
                    Console.WriteLine("Я не знаю, что делать с этим числом!");
                    break;
            }

            string b = Console.ReadLine();

            switch (b)
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестный символ");
                    break;
            }
        }
    }
}
