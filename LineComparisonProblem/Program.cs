using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            double x1 = 0, x2 = 0, x3=0, x4= 0, y1 = 0, y2 = 0, y3= 0, y4= 0;
            Console.Write("Enter the x1 co-ordinate: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y1 co-ordinate: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x2 co-ordinate: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y2 co-ordinate: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x3 co-ordinate: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y3 co-ordinate: ");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the x4 co-ordinate: ");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the y4 co-ordinate: ");
            y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The four points on the Cartesian Plane are A({x1},{y1}), B({x2},{y2}), C({x3},{y3}), D({x4},{y4})");
            double LengthAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double LengthCD = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Boolean b = LengthAB.Equals(LengthCD);
            if(b)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }   
        }
    }
}
