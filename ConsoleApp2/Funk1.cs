using System;

namespace ConsoleApp_1_1
{
    class Funk1
    {
        static double funct11(double c, double a, double x)
        {
            double y;
            if (c * x - a >= 0)
            {
                y = Math.Pow((c * x - a), 1.0 / 3) + Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x));
            }
            else
            {
                y = -Math.Pow(-(c * x - a), 1.0 / 3) + Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x));
            }
            return y;

        static void Main(string[] args)
        {
            double a, c, x, y;

            Console.WriteLine("Введите c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x=");
            x = Convert.ToDouble(Console.ReadLine());
                try
                {
                    Console.WriteLine("y= {0}", funct11(c,a,x));
                }
                catch 
                {
                    Console.WriteLine("Невозможно выполнить операции. Введите другие значения");       
                }
            Console.ReadKey();
            }
        }
    }
}
