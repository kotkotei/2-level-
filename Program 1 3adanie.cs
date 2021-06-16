using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {// Найти сумму кадртов вех цлыхчисел от a до b (значение a и b вводятся с клавы);
            // первое задание 3 уровня
            Console.WriteLine("Введи число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int v = 0;
            for(int i=a;i<=b;i++)
            {
                v = v + i * i;
            }
            Console.WriteLine("Ответ" + v);
            Console.ReadLine();
               
        }
    }
}
