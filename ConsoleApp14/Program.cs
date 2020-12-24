using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 10;
            double s = 3;
            double x = 2;
            double sum = 0;
            for (int i = 0; i < n; i++, s += 2)
            {
                sum += Math.Pow(-1, i) * (Math.Pow(x, s) / (s * (s - 2)));
                Console.WriteLine( s + " - " + (s * (s - 2)));
            }
            Console.WriteLine("Sum = {0:f3}", sum);
        }
    }
}
