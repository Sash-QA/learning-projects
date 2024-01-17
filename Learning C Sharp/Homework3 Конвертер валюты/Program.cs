using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Конвертер_валюты
{
    internal class Program
    {
        static void Main(string[] args)

        // Домашнее задание - конвертер валюты

        {
            double RubToUsd = 0.017;
            double RubToGbp = 0.014;
            double RUB;

            Console.WriteLine("Введите сумму в рублях");
            RUB = double.Parse(Console.ReadLine());

            Console.WriteLine(RUB + " рублей в долларах США = " + RUB * RubToUsd);
            Console.WriteLine(RUB + " рублей в английских фунтах = " + RUB * RubToGbp);
        }
    }
}
