using System;
using System.Globalization;  // Это пространство имен позволяет использовать региональные особенности данных, например точку вместо запятой для отделения дробной части

namespace Lesson3_System.Globalization
{               
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "9.4";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()  // Класс из пространства имен System.Globalization
            {
                NumberDecimalSeparator = ".",                           // Указываем точку в качестве разделителя дробной части
            };

            // Метод Parse конвертирует только данные типа string. В данном случае конвертируем строку в целое число c точкой

            double a = double.Parse(str, numberFormatInfo);             // Через запятую вторым параметрои метода Parse передаем объект NumberFormatInfo

            Console.WriteLine(a);
        }
    }
}
