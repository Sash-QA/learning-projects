using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Консольный_калькулятор                                      // Консольный калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)            // Цикл, повторяющий код программы. В скобках можно задать условия, при которых цикл будет выполняться
            {
                Console.Clear();    // Очищает консоль перед началом выполнения новых операций

                Console.WriteLine("------------------------------------------КАЛЬКУЛЯТОР-----------------------------------------");
                Console.WriteLine("Доступны операции сложения (+), вычитания (-), умножения (*) и деления (/) между двумя числами.");
                Console.WriteLine();

                double firstNum, secondNum;
                string oper;

                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter:");
                    firstNum = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите оператор и нажмите Enter:");
                    oper = Console.ReadLine();

                    Console.WriteLine("Введите второе число и нажмите Enter:");
                    secondNum = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введены некорректные данные. Пожалуйста, попробуйте еще раз.");
                    Console.ReadLine();
                    continue;       // Отправляет нас после ошибки в начало цикла while
                }


                // С использованием if else
                /*
                if (oper == "+")
                    Console.WriteLine("Результат: " + (firstNum + secondNum));

                else if (oper == "-")
                    Console.WriteLine("Результат: " + (firstNum - secondNum));

                else if (oper == "*")
                    Console.WriteLine("Результат: " + (firstNum * secondNum));

                else if (oper == "/")
                    {
                        if (secondNum == 0)
                            Console.WriteLine("Невозможно разделить на ноль.");

                        else 
                            Console.WriteLine("Результат: " + (firstNum / secondNum));
                    }
                else
                    Console.WriteLine("Ошибка. Доступные операторы: '+', '-', '*' и '/'.");
                */

                // С использованием switch

                switch (oper)
                {
                    case "+":
                        Console.WriteLine("Результат: " + (firstNum + secondNum));
                        break;

                    case "-":
                        Console.WriteLine("Результат: " + (firstNum - secondNum));
                        break;

                    case "*":
                        Console.WriteLine("Результат: " + (firstNum * secondNum));
                        break;

                    case "/":
                        {
                            if (secondNum == 0)
                                Console.WriteLine("Невозможно разделить на ноль.");

                            else
                                Console.WriteLine("Результат: " + (firstNum / secondNum));
                        }
                        break;

                    default:
                        Console.WriteLine("Ошибка. Доступные операторы: '+', '-', '*' и '/'.");
                        break;
                }
                Console.ReadLine();     // Ставится для того, чтобы мы могли увидеть результат до закрытия или очистки консоли.
            }
        }
    }
}
