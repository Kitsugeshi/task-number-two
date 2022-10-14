using System;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            Double c = Convert.ToDouble(Console.ReadLine());
            Double D = (b * b - 4 * a * c);

            if (D < 0)
            { 
                Console.WriteLine("Нет решений.");
            }
            else if (D == 0)
            { 
                Console.WriteLine($"x = {-b / (2 * a)}");
            }
            else if (D > 0)
            {
                Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}");
                Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / (2 * a)}");
            }
        }
    }
}
