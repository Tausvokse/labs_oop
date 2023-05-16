using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

class Additional
{
    public static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    public static double SetValues(string name)
    {
        double result;
        while (true)
        {
            try
            {
                result = ReadDouble($"Enter the value {name}: ");
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        return result;
    }

    public static double[] GenerateRandomArray(int length)
    {
        double[] array = new double[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(-50, 50);
        }

        return array;
    }
}

class Expression
{
    private double A, D, C;

    public Expression()
    {
        this.A = 0;
        this.D = 0;
        this.C = 0;
    }

    public Expression(double a, double d, double c)
    {
        if (42 / d < 0 || a + c - 1 == 0)
        {
            throw new Exception("Incorrect values of operands.");
        }
        this.A = a;
        this.D = d;
        this.C = c;
    }

    public Expression(double[] values)
    {
        if (values.Length != 3)
        {
            throw new ArgumentException("Array length must be 3.");
        }
        if (42 / values[1] < 0 || values[0] + values[2] - 1 == 0)
        {
            throw new Exception("Incorrect values of operands.");
        }
        this.A = values[0];
        this.D = values[1];
        this.C = values[2];
    }

    public double Calculate()
    {
        return Math.Round(((2 * C) - D * Math.Sqrt(42 / D)) / (C + A - 1), 2);
    }

    public double GetA() { return A; }
    public double GetD() { return D; }
    public double GetC() { return C; }

    public void SetA(double a) { this.A = a; }
    public void SetD(double d) { this.D = d; }
    public void SetC(double c) { this.C = c; }

}

class Program
{
    static void Main()
    {
        bool checker = false;
        string answer1;
        while (!checker)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you want to set values from the keyboard? 'Y' - yes");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                while (answer.ToLower() == "y")
                {
                    try
                    {
                        double a = Additional.SetValues("a"), b = Additional.SetValues("b"), c = Additional.SetValues("c");
                        Expression expr = new Expression(a, b, c);
                        Console.WriteLine($"A = {expr.GetA()}; D = {expr.GetD()}; C = {expr.GetC()};");
                        Console.WriteLine($"Result: {expr.Calculate()}");
                        Console.WriteLine("U still want to do that?? 'Y' - yes");
                        answer = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("How many times u want to check calculations from random values?");
                int i = Int32.Parse(Console.ReadLine());
                int counter = 0;
                while (counter < i)
                {
                    try
                    {
                        Expression exp = new Expression(Additional.GenerateRandomArray(3));
                        Console.WriteLine($"A = {exp.GetA()}; D = {exp.GetD()}; C = {exp.GetC()};");
                        Console.WriteLine($"Result: {exp.Calculate()}");
                        counter++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do u want to do that thing again? Y - Yes, N - No");
            answer1 = Console.ReadLine();
            if (answer1.ToLower() == "n")
            {
                checker = true;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}