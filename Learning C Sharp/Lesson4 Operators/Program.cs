using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace Lesson4_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;                      // Символ "=" это оператор присваивания
            double b = 3;
            double c = 20;

            double result1 = a + b + c;         // Символы "+", "-", "*", "/" и "%" это арифмитические операторы. "%" отделяет дробную часть от целого
            double result2 = a * b * c;         // Порядок выполнения арифметических операций - 1. "()", 2. "*" и "/" и "%", 3. "+" и "-"
            double result3 = a + b * c;         // Операции с одинаковым приоритетом выполняются слева направо

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
