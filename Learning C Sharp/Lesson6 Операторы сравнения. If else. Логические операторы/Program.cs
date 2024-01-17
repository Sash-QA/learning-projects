using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Операторы_сравнения._If_else._Логические_операторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                                        Операторы сравнения
                                       
                                        ==  Равно
                                        !=  Не равно
                                        >   Больше
                                        <   Меньше
                                        >=  Больше или равно
                                        <=  Меньше или равно
            */

            int a = 5;
            int b = 4;
            bool result = a == b;

            Console.WriteLine(result);  // Консоль вернет False, так как проверка на равенство не прошла

            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);


            // Конструкция If/Else

            bool isInfected = true;

            if (isInfected)
            {
                Console.WriteLine("Персонаж заражён!");
            }
            else
            {
                Console.WriteLine("Персонаж здоров");
            }

            // If/Else с выражениями

            int c = int.Parse(Console.ReadLine());

            if (c == 5)
            {
                Console.WriteLine("с равно 5");
            }
            else
            {
                Console.WriteLine("с не равно 5");
            }


            /*                  Логические операторы
             *                  
             *                  &&      Сокращенное И
             *                  ||      Сокращенное ИЛИ
             *                  &       И
             *                  |       ИЛИ
             *                  !       НЕ (унарный)
             *                  
             *                  Сокращенные операторы не проверяют вторую часть условия, если в этом нет необходимости. Это помогает ускорить работу программы
             */

            bool isInfected2 = false;

            if (!isInfected2)
            {
                Console.WriteLine("Персонаж здоров!");
            }
            else
            {
                Console.WriteLine("Персонаж заражён");
            }

            int fanSpeed = 0;

            bool isHighTemperature = true;
            bool hasNoCooling = fanSpeed <= 0;    // Оператор меньше или равно ставится на случай, если в результате бага скорость вентилятора определится как отрицательная

            if (isHighTemperature && hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
        }
    }
}
