using System;

class Figures
{
    public virtual double GetArea() { return 0; }
    public virtual double GetLenght() {  return 0; }

    static int ReadInt32(string prompt)
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

class Ellipse : Figures
{
    private double MainAxis;
    private double DerivedAxis;
    
    public Ellipse(double MainAxis, double DerivedAxis)
    {
        this.MainAxis = MainAxis;
        this.DerivedAxis = DerivedAxis;
    }

    public override double GetArea() 
    { 
        return Math.Round(Math.PI * MainAxis * DerivedAxis, 2); 
    }
    public override double GetLenght() 
    { 
        return Math.Round(Math.PI * Math.Sqrt((MainAxis * MainAxis + DerivedAxis * DerivedAxis) / 2), 2); 
    }
}

class Circle : Figures
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }

    public override double GetLenght()
    {
        return Math.Round(Math.PI * 2 * radius, 2);
    }
}

class Program
{
    static void Main(string[] args) {
        Console.ForegroundColor = ConsoleColor.Green;
        bool checker = false;
        string answer;
        while (!checker)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Figures ellipse;
            Figures circle;
            ellipse = new Ellipse(Figures.SetValues(), Figures.SetValues());
            circle = new Circle(Figures.SetValues());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Length of ellipse: {ellipse.GetLenght()}");
            Console.WriteLine($"Length of circle: {circle.GetLenght()}");
            Console.WriteLine($"Area of Ellipse: {ellipse.GetArea()}");
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do u want to do that thing again? Y - Yes, N - No");
            answer = Console.ReadLine();
            if(answer.ToLower() == "n")
            {
                checker = true;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}