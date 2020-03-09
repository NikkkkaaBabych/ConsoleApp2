using System;

namespace ConsoleApp_1_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double c, x, y, xmin, xmax, dx;
            Console.WriteLine("Введите c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmin=");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmax=");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите dx=");
            dx = Convert.ToDouble(Console.ReadLine());
            if (((xmax < xmin) && (dx > 0)) || (dx == 0) || (xmin == xmax) || ((xmax > xmin) && (dx < 0)))
            {
                Console.WriteLine("Пожалуста, введите что-то адекватное");
            }
            else
            {
                for (x = xmin; x <= xmax; x += dx)
                {
                    y = Math.Pow(c * c * x * x + 2, 1.0/3) + Math.Log(x * x + 1)/ (2 * Math.PI);
                    Console.WriteLine("x={0} y={1}", x,y);
                }
            }
            Console.ReadKey();

        }
    }
}
