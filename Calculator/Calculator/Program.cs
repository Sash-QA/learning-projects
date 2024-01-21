using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public static double Divide(double firstNum, double secondNum)
        {
            if (secondNum == 0)
                
                throw new ArgumentException("Невозможно разделить на ноль. Для продолжения работы с калькулятором нажмите Enter.");

            return firstNum / secondNum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                PrintHeader();

                double firstNum, secondNum, result;
                string oper;

                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter:");
                    firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Введите оператор и нажмите Enter:");
                    oper = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(oper) || !IsOperatorValid(oper))
                    {
                        Console.WriteLine("Введен некорректный оператор. Доступные операторы: '+', '-', '*' и '/'. Нажмите Enter и попробуйте снова.");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine();

                    Console.WriteLine("Введите второе число и нажмите Enter:");
                    secondNum = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено некорректное число. Нажмите Enter и попробуйте снова.");
                    Console.ReadLine();
                    continue;
                }
                switch (oper)
                {
                    case "+":
                        result = Calculator.Add(firstNum, secondNum);
                        PrintResult(result);
                        break;

                    case "-":
                        result = Calculator.Subtract(firstNum, secondNum);
                        PrintResult(result);
                        break;

                    case "*":
                        result = Calculator.Multiply(firstNum, secondNum);
                        PrintResult(result);
                        break;

                    case "/":
                        try
                        {
                            result = Calculator.Divide(firstNum, secondNum);
                            PrintResult(result);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("В ходе выполнения программы произошла ошибка. Нажмите Enter и попробуйте снова.");
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();
            }
        }

        private static bool IsOperatorValid(string oper)
        {
            return oper == "+" || oper == "-" || oper == "*" || oper == "/";
        }

        static void PrintResult(double result)
        {
            Console.WriteLine($"Результат: {result}. Для продолжения работы с калькулятором нажмите Enter.");
            Console.WriteLine();
        }

        static void PrintHeader()
        {
            Console.WriteLine("------------------------------------------КАЛЬКУЛЯТОР--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Доступны операции сложения (+), вычитания (-), умножения (*) и деления (/) c двумя числами.");
            Console.WriteLine("Для отделения дробной части используйте запятую.");
            Console.WriteLine();
        }
    }
}
