using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, c, x, y;

            Console.WriteLine("Введите c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x=");
            x = Convert.ToDouble(Console.ReadLine());
            if ((2 * Math.Sin(Math.PI / 3 + x) == 0) || (x <= 0))
            {
                Console.WriteLine("Невозможно выполнить операции. Введите другие значения");
            }
            else
            {
                if (c * x - a >= 0)
                {
                    y = Math.Pow((c * x - a), 1.0 / 3) + (Math.Log(x)) / (2 * Math.Sin(Math.PI / 3 + x));
                }
                else
                {
                    y = -Math.Pow(-(c * x - a), 1.0 / 3) + (Math.Log(x)) / (2 * Math.Sin(Math.PI / 3 + x));
                }
                Console.WriteLine("y= {0}", y);
            }
            Console.ReadKey();
        }
    }
}
