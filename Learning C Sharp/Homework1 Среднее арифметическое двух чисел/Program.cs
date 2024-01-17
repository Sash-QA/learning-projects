using System;

namespace Homework1_Среднее_арифметическое_двух_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание - написать программу, вычисляющую среднее арифметическое двух чисел

            double firstValue, secondValue;     // Переменные можно было бы назвать "a" и "b", но хорошим тоном считается, если эти переменные будут самоописывающимися

            Console.WriteLine("Введите первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Среднее арифметическое = " + result);
        }
    }
}
