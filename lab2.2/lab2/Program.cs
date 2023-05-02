using System;

class Additional
{
    public static int ReadInt32(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    public static double SetValues()
    {
        int result;
        while (true)
        {
            try
            {
                result = ReadInt32("Enter the value: ");
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }


        return result;
    }
}

interface ICalculatingFigureProperties
{
    double Perimeter { get; }
    double CalculateArea();
}

internal class Circle : ICalculatingFigureProperties
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Perimeter
    {
        get { return 2 * Math.PI * radius; }
    }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }
}

internal class Ellipse : ICalculatingFigureProperties
{
    private double semiMajorAxis;
    private double semiMinorAxis;
    private double eccesintresitet;

    public Ellipse(double semiMajorAxis, double semiMinorAxis)
    {
        this.semiMajorAxis = semiMajorAxis;
        this.semiMinorAxis = semiMinorAxis;
    }

    public double Perimeter
    {
        get
        {
            return Math.Round(Math.PI * Math.Sqrt((semiMajorAxis * semiMajorAxis + semiMinorAxis * semiMinorAxis) / 2), 2);
        }
    }

    public double CalculateArea()
    {
            return Math.Round(Math.PI * semiMajorAxis * semiMinorAxis, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        bool checker = false;
        string answer;
        while (!checker)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ICalculatingFigureProperties circle = new Circle(Additional.SetValues());
            ICalculatingFigureProperties ellipse = new Ellipse(Additional.SetValues(), Additional.SetValues());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Circle perimeter: " + circle.Perimeter);
            Console.WriteLine("Circle area: " + circle.CalculateArea());
            Console.WriteLine("Ellipse perimeter: " + ellipse.Perimeter);
            Console.WriteLine("Ellipse area: " + ellipse.CalculateArea());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do u want to do that thing again? Y - Yes, N - No");
            answer = Console.ReadLine();
            if (answer.ToLower() == "n")
            {
                checker = true;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
