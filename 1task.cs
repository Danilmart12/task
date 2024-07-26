using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation Solver ax^2 + bx + c = 0");
        Console.WriteLine("Enter coefficients a, b, c:");

        double a, b, c;
        while (true)
        {
            Console.Write("a = ");
            string inputA = Console.ReadLine();
            if (double.TryParse(inputA, out a))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a numerical value for a.");
            }
        }

        while (true)
        {
            Console.Write("b = ");
            string inputB = Console.ReadLine();
            if (double.TryParse(inputB, out b))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a numerical value for b.");
            }
        }

        while (true)
        {
            Console.Write("c = ");
            string inputC = Console.ReadLine();
            if (double.TryParse(inputC, out c))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a numerical value for c.");
            }
        }

        Console.WriteLine($"Quadratic equation: {a}x^2 + {b}x + {c} = 0");

        double discriminant = b * b - 4 * a * c;
        Console.WriteLine($"Discriminant D = {discriminant}");

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Equation solutions: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Equation solution: x = {x}");
        }
        else
        {
            Console.WriteLine("The equation has no real solutions.");
        }

        Console.ReadLine();
    }
}

