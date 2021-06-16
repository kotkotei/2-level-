using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {//7.	Одноклеточная амеба каждые 3 часа делится на 2 клетки. 
            //Определить, сколько клеток будет через 3,6,9,...,24 часа.
            int n = 2;
            for (int i = 3; i <= 24; i = i + 3)
            {
                Console.WriteLine("через" + i + "через час стоько омёб" + n);
                n = i * 2;
            }
            Console.WriteLine(n);
        
            Console.ReadKey();


        }
    }
}
