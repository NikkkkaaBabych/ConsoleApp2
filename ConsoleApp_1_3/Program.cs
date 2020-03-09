using System;

namespace ConsoleApp_1_3
{
    class Program
    {
        static double funct13 (double a, double k, double x)
        {
            double y;
            double COS = Math.Cos(a * x);
            y = Math.Pow(Math.Abs(COS), 1.0 / 3) * Math.Abs(COS) / COS + k * COS / Math.Log(a * x);
            return y;
        }
                
        static void Main(string[] args)
        {
            double a, k, x, y, xmin, xmax, dx;
            Console.WriteLine("Введите a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите k=");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmin=");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmax=");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите dx=");
            dx = Convert.ToDouble(Console.ReadLine());
            try
            {
                for (x = xmin; x <= xmax; x += dx)
                {
                    Console.WriteLine("x={0} y={1}", x, funct13(a, k, x)); 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Пожалуста, введите другие значения");
            }
            Console.ReadKey();
        }
        
    }
}
