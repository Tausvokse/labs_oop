using lab1._1_1;

class Program
{
    static void NotMain()
    {
        Line.Linia[] lines = new Line.Linia[11];

        Line.Initial(lines);

        Line.Mirror(lines);

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"Line {i}: ({lines[i].start.x}, {lines[i].start.y}), ({lines[i].end.x}, {lines[i].end.y})");
        }
    }

    static void Main()
    {
        Line line1 = new Line();

        do
        {
            Console.Write("Enter the coordinates of the first point (x1, y1): ");
            while (!float.TryParse(Console.ReadLine(), out line1.xA) || !float.TryParse(Console.ReadLine(), out line1.yA))
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
                Console.Write("Enter the coordinates of the first point (x1, y1): ");
            }

            Console.Write("Enter the coordinates of the second point (x2, y2): ");
            while (!float.TryParse(Console.ReadLine(), out line1.xB) || !float.TryParse(Console.ReadLine(), out line1.yB))
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
                Console.Write("Enter the coordinates of the second point (x2, y2): ");
            }

            float dovzhina1 = line1.dovzhina();
            float kyt1 = line1.kyt();

            do
            {
                if (line1.yA == line1.yB && line1.xA == line1.xB)
                {
                    Console.WriteLine("Its a point, not a line...");
                    break;
                }

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("0: Show your cordinates");
                Console.WriteLine("1: Calculate length of line segment");
                Console.WriteLine("2: Calculate angle between line segment and X-axis");
                Console.WriteLine("3: Do all operations (0-2)");
                Console.WriteLine("4: Restart programm");
                Console.WriteLine("5: Stop programm");
                Console.WriteLine("6: See the additional part of lab");

                int.TryParse(Console.ReadLine(), out line1.dia);
                line1.oper4 = false;

                switch (line1.dia)
                {
                    case 0:
                        Console.WriteLine($"A({line1.xA};{line1.yA}) and B({line1.xB};{line1.yB})");
                        break;
                    case 1:
                        Console.WriteLine($"Dovzhina is: {dovzhina1}");
                        break;
                    case 2:
                        Console.WriteLine($"Kyt is: {kyt1}");
                        break;
                    case 3:
                        Console.WriteLine($"A({line1.xA};{line1.yA}) and B({line1.xB};{line1.yB})");
                        Console.WriteLine($"Dovzhina is: {dovzhina1}");
                        Console.WriteLine($"Kyt is: {kyt1}");
                        break;
                    case 4:
                        line1.oper4 = true;
                        break;
                    case 5:
                        return;
                    case 6:
                        Program.NotMain();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter from 0 to 6.");
                        break;
                }

                if (line1.oper4)
                {
                    break;
                }

            } while (line1.dia <= 5 || line1.dia >= 0);

            line1.choice = 'y';

        } while (line1.choice == 'Y' || line1.choice == 'y');
    }
}