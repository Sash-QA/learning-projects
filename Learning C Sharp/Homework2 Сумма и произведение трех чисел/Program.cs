using System;

namespace Homework2_Сумма_и_произведение_трех_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание - вывод на экран значений суммы и произведения трех чисел, вводимых в консоль

            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;
            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("Сумма чисел = " + sumResult);
            Console.WriteLine("Произведение чисел = " + multResult);
        }
    }
}
