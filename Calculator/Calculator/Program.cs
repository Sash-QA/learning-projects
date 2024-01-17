using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("------------------------------------------КАЛЬКУЛЯТОР--------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Доступны операции сложения (+), вычитания (-), умножения (*) и деления (/) c двумя числами.");
                Console.WriteLine("Для отделения дробной части используйте запятую.");
                Console.WriteLine();

                double firstNum, secondNum, result;
                string oper;

                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter:");
                    firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Введите оператор и нажмите Enter:");
                    oper = Console.ReadLine();
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
                        Console.WriteLine("Результат: " + (result = firstNum + secondNum) + ". Для продолжения работы с калькулятором нажмите Enter.");
                        Console.WriteLine();
                        break;

                    case "-":
                        Console.WriteLine("Результат: " + (result = firstNum - secondNum) + ". Для продолжения работы с калькулятором нажмите Enter.");
                        Console.WriteLine();
                        break;

                    case "*":
                        Console.WriteLine("Результат: " + (result = firstNum * secondNum) + ". Для продолжения работы с калькулятором нажмите Enter.");
                        Console.WriteLine();
                        break;

                    case "/":
                        {
                            if (secondNum == 0)
                            {
                                Console.WriteLine("Невозможно разделить на ноль. Для продолжения работы с калькулятором нажмите Enter.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Результат: " + (result = firstNum / secondNum) + ". Для продолжения работы с калькулятором нажмите Enter.");
                                Console.WriteLine();
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Введен некорректный оператор. Доступные операторы: '+', '-', '*' и '/'. Нажмите Enter и попробуйте снова.");
                        Console.WriteLine();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
