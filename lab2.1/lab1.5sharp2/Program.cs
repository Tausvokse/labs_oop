public class Point
{
    protected double x;
    protected double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }
}

public class Line : Point
{
    protected double x2;
    protected double y2;

    public Line(double x1, double y1, double x2, double y2) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
    }

    public double X2
    {
        get { return x2; }
        set { x2 = value; }
    }

    public double Y2
    {
        get { return y2; }
        set { y2 = value; }
    }

    public double Length()
    {
        return Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
    }
}

public class Rectangle : Line
{
    protected double x3;
    protected double y3;
    protected double x4;
    protected double y4;
    protected double height;


public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2)
    {
        this.x3 = x3;
        this.y3 = y3;
        this.x4 = x4;
        this.y4 = y4;

        if (!IsRectangle())
        {
            throw new ArgumentException("Not a rectangle.");
        }

        height = Math.Sqrt(Math.Pow(y4 - y1, 2) + Math.Pow(x4 - x1, 2));
    }

    public double X3
    {
        get { return x3; }
        set { x3 = value; }
    }

    public double Y3
    {
        get { return y3; }
        set { y3 = value; }
    }

    public double X4
    {
        get { return x4; }
        set { x4 = value; }
    }

    public double Y4
    {
        get { return y4; }
        set { y4 = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Area()
    {
        return Length() * height;
    }

    public double Perimeter()
    {
        return 2 * Length() + 2 * height;
    }

    private bool IsRectangle()
    {
        double cx, cy;
        double dd1, dd2, dd3, dd4;

        cx = (X + X2 + x3 + x4) / 4;
        cy = (Y + Y2 + y3 + y4) / 4;

        dd1 = Math.Sqrt(Math.Pow(cx - X, 2) + Math.Pow(cy - Y, 2));
        dd2 = Math.Sqrt(Math.Pow(cx - X2, 2) + Math.Pow(cy - Y2, 2));
        dd3 = Math.Sqrt(Math.Pow(cx - x3, 2) + Math.Pow(cy - y3, 2));
        dd4 = Math.Sqrt(Math.Pow(cx - x4, 2) + Math.Pow(cy - y4, 2));
        return dd1 == dd2 && dd1 == dd3 && dd1 == dd4 && dd1 != 0 && dd2 != 0 && dd3 != 0 && dd4 != 0;
    }

}

class Program
{
    static void Main(string[] args)
    {
        bool restart = true;
        while (restart)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter coordinates of first point");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates of second point:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);

            Line line = new Line(point1.X, point1.Y, point2.X, point2.Y);

            Rectangle rectangle = null;
            while (rectangle == null)
            {
                Console.WriteLine("Enter two more point (4 coordinates):");
                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());

                double x4 = double.Parse(Console.ReadLine());
                double y4 = double.Parse(Console.ReadLine());

                Point point3 = new Point(x3, y3);
                Point point4 = new Point(x4, y4);

                rectangle = new Rectangle(point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y, point4.X, point4.Y);
            }

            Console.WriteLine($"Height line: {line.Length()}");
            Console.WriteLine($"Lenght of rectangle: {rectangle.Height}");
            Console.WriteLine($"Area of the rectangle: {rectangle.Area()}");
            Console.WriteLine($"Perimetr of rectangle: {rectangle.Perimeter()}");
            Console.WriteLine("Do you want to restart? Yes - 'Y', No - 'N'. Press 'S' to exit.");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "n")
            {
                restart = false;
            }
            else if (answer.ToLower() == "s")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Environment.Exit(0);
            }
        }
    }
}