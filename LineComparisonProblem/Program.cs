using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            Console.Write("Enter the x1 co-ordinate: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y1 co-ordinate: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x2 co-ordinate: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y2 co-ordinate: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The two points on the Cartesian Plane are A({x1},{y1}), B({x2},{y2})");
            Console.WriteLine("The length of line is: " + Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
}
