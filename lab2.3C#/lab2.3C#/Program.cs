using System;

class Point<T>
{
    private readonly T X;
    private readonly T Y;

    public Point() { }
    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }

    public T GetX() { return X; }
    public T GetY() { return Y; }
}

class Trapezoid<T>
{
    private Point<T>[] points = new Point<T>[4];
    private double side, high, foundsmall, foundlarge;

    public Trapezoid(Point<T> A, Point<T> B, Point<T> C, double side)
    {
        points[0] = A;
        points[3] = A;
        points[1] = B;
        points[2] = C;
        this.side = side;

        high = Math.Sqrt(Convert.ToDouble(Math.Pow(Convert.ToDouble(points[1].GetX()), 2)
                        + Math.Pow(Convert.ToDouble(points[1].GetY()), 2)));

        foundsmall = Math.Sqrt(Convert.ToDouble(Math.Pow(Convert.ToDouble(points[2].GetX()), 2)
                        + Math.Pow(Convert.ToDouble(points[2].GetY()), 2)));

        double sideSquared = Math.Pow(side, 2);
        double highSquared = Math.Pow(high, 2);

        points[0] = new Point<T>((T)Convert.ChangeType(Convert.ToDouble(points[3].GetX()) - Math.Sqrt(sideSquared - highSquared), typeof(T)),
                                 points[0].GetY());
        foundlarge = foundsmall + (2 * (Math.Sqrt(sideSquared - highSquared)));
        points[3] = new Point<T>((T)Convert.ChangeType(Convert.ToDouble(points[2].GetX()) + Math.Sqrt(sideSquared - highSquared), typeof(T)),
                                 points[3].GetY());
    }

    public double Perimeter() { return foundsmall + foundlarge + (side * 2); }
    public double Area() { return high * ((foundlarge + foundsmall) / 2); }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        while (true)
        {
            try
            {
                string restartChoice;
                do
                {
                    bool validTrapezoid = false;
                    Point<double> a = null;
                    Point<double> b = null;
                    Point<double> c = null;
                    double side = 0;

                    while (!validTrapezoid)
                    {
                        Console.WriteLine("Enter the coordinates and side length for the trapezoid:");
                        Console.Write("Point A - X: ");
                        double ax = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Point A - Y: ");
                        double ay = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Point B - X: ");
                        double bx = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Point B - Y: ");
                        double by = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Point C - X: ");
                        double cx = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Point C - Y: ");
                        double cy = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Side length: ");
                        side = Convert.ToDouble(Console.ReadLine());

                        a = new Point<double>(ax, ay);
                        b = new Point<double>(bx, by);
                        c = new Point<double>(cx, cy);

                        double abDistance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
                        double acDistance = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
                        double bcDistance = Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2));

                        if (abDistance != 0 && acDistance != 0 && bcDistance != 0 &&
                            (abDistance + acDistance > bcDistance) &&
                            (abDistance + bcDistance > acDistance) &&
                            (acDistance + bcDistance > abDistance))
                        {
                            validTrapezoid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid trapezoid. Please enter valid coordinates and side length.");
                        }
                    }

                    Trapezoid<double> figureDouble = new Trapezoid<double>(a, b, c, side);
                    Console.WriteLine("Perimeter = " + Math.Round(figureDouble.Perimeter(), 2));
                    Console.WriteLine("Area = " + Math.Round(figureDouble.Area(), 2));

                    Console.WriteLine("Do you want to restart the program? (Y/N)");
                    restartChoice = Console.ReadLine();
                } while (restartChoice.Equals("Y", StringComparison.OrdinalIgnoreCase));
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }


        Console.ResetColor();
    }
}