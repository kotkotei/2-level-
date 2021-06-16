using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//2.	Найти среднее арифметическое всех целых чисел от a до b.
            // 3 уровень 2 задание
            Console.WriteLine("Введи число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число b");
            int b = Convert.ToInt32(Console.ReadLine());

            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s = s + i;
            }
            int m = b - a + 1;
            double c = 1.0 * s / m;
                
            
            Console.WriteLine("Ответ" + c);
            Console.ReadLine();
        }
    }
}
