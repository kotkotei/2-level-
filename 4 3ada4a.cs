using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//4.	Дано натуральное число. Определить количество цифр 3 в нем
            //3 трети уровен 4 д
            Console.WriteLine("Введи число");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (x != 0)
            {
                int a = x % 10;
                if (a == 3)
                {
                    n++;
                }
                x = x / 10;
            }
            
                Console.WriteLine(n);
            
            Console.ReadKey();
        }
    }
}

