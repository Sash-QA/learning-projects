using System;

namespace Calculator
{
    public class Calculator
    {
        public static double Add(double firstNum, double secondNum)         // Определение статических методов для арифметических операций
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
            if (secondNum == 0)                                             // Отображение ошибки при попытке деления на ноль
                
                throw new ArgumentException("Невозможно разделить на ноль. Для продолжения работы с калькулятором нажмите Enter.");

            return firstNum / secondNum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)                                     // Точка входа в программу
        {
            while (true)
            {
                Console.Clear();                                            // Очистка консоли перед новым циклом
                PrintHeader();                                              // Вывод заголовка

                double firstNum, secondNum, result;                         // Объявление переменных для чисел
                string oper;                                                // Объявление переменной для оператора

                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter:");
                    firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Введите оператор и нажмите Enter:");
                    oper = Console.ReadLine();
                    Console.WriteLine();

                    switch (oper)                                           // Проверка корректности оператора
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            break;
                        default:
                            Console.WriteLine("Введен некорректный оператор. Доступные операторы: '+', '-', '*' и '/'. Нажмите Enter и попробуйте снова.");
                            Console.ReadLine();
                            continue;
                    }

                    Console.WriteLine("Введите второе число и нажмите Enter:");
                    secondNum = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)                                           // Отображение ошибки при некорректном вводе чисел
                {
                    Console.WriteLine();
                    Console.WriteLine("Введено некорректное число. Нажмите Enter и попробуйте снова.");
                    Console.ReadLine();
                    continue;
                }
                switch (oper)                                               // Выбор операции в зависимости от введенного оператора
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

                    default:                                                // Сообщение при непредвиденных ошибках
                        Console.WriteLine("В ходе выполнения программы произошла ошибка. Нажмите Enter и попробуйте снова.");
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();                                         // Позволяет избежать завершения цикла, чтобы успеть увидеть результат операции
            }
        }

        static void PrintResult(double result)                              // Вывод результата
        {
            Console.WriteLine($"Результат: {result}. Для продолжения работы с калькулятором нажмите Enter.");
            Console.WriteLine();
        }

        static void PrintHeader()                                           // Вывод заголовка
        {
            Console.WriteLine("------------------------------------------КАЛЬКУЛЯТОР--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Доступны операции сложения (+), вычитания (-), умножения (*) и деления (/) c двумя числами.");
            Console.WriteLine("Для отделения дробной части используйте запятую.");
            Console.WriteLine();
        }
    }
}
