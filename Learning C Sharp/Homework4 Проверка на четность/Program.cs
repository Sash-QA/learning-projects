using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Проверка_на_четность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание - проверка вводимых чисел на четность

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)

            /*      if проверяет булевое значение, а значит, сначала он производит вычисления, а затем проверяет результат на истинность
             *      Развернуто это можно записать так:
             *      
             *      int temp = a % 2;
             *      bool result = temp == 0;
             *      if (result)
             */
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
