public class MyMatrix
{
    private int[,] array;
    private int sum;

    public MyMatrix(int rows, int cols)
    {
        array = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 100);
                sum += array[i, j];
            }
        }
    }

    public double this[int row]
    {
        get
        {
            int cols = array.GetLength(1);
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[row, j];
            }
            double mean = (double)sum / cols;
            double variance = 0;
            for (int j = 0; j < cols; j++)
            {
                variance += Math.Round(Math.Pow(array[row, j] - mean, 2), 2);
            }
            return Math.Sqrt(variance / cols);
        }
    }

    public static bool AskToRestart()
    {
        Console.Write("Do you want to restart the program? (Y/N): ");
        string input = Console.ReadLine();


        if (input.ToUpper() == "Y")
        {
            return true;
        }

        else if (input.ToUpper() == "N")
        {
            return false;
        }

        else
        {
            Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
            return AskToRestart();
        }
    }

    public void PrintMatrix()
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static int SetValues()
    {
        int value = 0;
        bool validInput = false;
        while (!validInput)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out value))
            {
                value = int.Parse(input);
                validInput = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        return value;
    }

    public int Sum
    {
        get { return sum; }
    }
}

public class Program {
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    beginning:
        Console.Clear();
        Console.WriteLine("Enter cols and rows");
        int a = MyMatrix.SetValues();
        int b = MyMatrix.SetValues();
        MyMatrix matrix = new MyMatrix(a, b);

        Console.WriteLine("Ur matrix:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        matrix.PrintMatrix();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter rows u want to get serednokvadratichne znachennya");
        int c = MyMatrix.SetValues() - 1;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Your serednokvadratichne znachennya is: " + matrix[c]);

        Console.WriteLine("Sum of all elements of array is: " + matrix.Sum);
        Console.ForegroundColor = ConsoleColor.Green;

        if (MyMatrix.AskToRestart())
        {
            goto beginning;
        }
        Console.ForegroundColor = ConsoleColor.Black;
    }
}