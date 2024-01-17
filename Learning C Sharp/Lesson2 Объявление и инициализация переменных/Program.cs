using System;

namespace Lesson2_Объявление_и_инициализация_переменных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string data;                                    // Объявление переменной data, в которой будут храниться данные, вводимые в консоли
            data = Console.ReadLine();                      // Класс Console с методом Readline позволяет вводить данные в консоли
            Console.WriteLine("Привет, " + data + "!");     // Если ввести в консоль свое имя, то после нажания Enter программа поприветствует вас

            string str;                                     // Объявление строковой переменной
            int a, b;                                       // Объявление переменных, в которые мы будем конвертировать строки из консоли в целые числа

            Console.WriteLine("Введиите первое число");
            str = Console.ReadLine();                       // Ввод первого числа
            a = Convert.ToInt32(str);                       // Конвертация переменной "a" в целое число

            Console.WriteLine("Введиите второе число");
            str = Console.ReadLine();                       // Ввод второго числа
            b = Convert.ToInt32(str);                       // Конвертация переменной "b" в целое число

            int result = a + b;                             // Объявление и инициализация переменной для отображения результата сложения
            Console.WriteLine("Сумма чисел = " + result);   // Отображение результата сложения двух целых чисел
        }
    }
}
