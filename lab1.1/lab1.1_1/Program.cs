using lab1._1_1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // створення змінних для подальшого утворенння класу
        //A
        Console.WriteLine("Enter xA");
        float xA = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter yA");
        float yA = float.Parse(Console.ReadLine());

        //B
        Console.WriteLine("Enter xB");
        float xB = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter yB");
        float yB = float.Parse(Console.ReadLine());

        //створення об'єкта класу
        Line line1 = new Line(xA, yA, xB, yB);
        float P = line1.dovzhina();
        float S = line1.kyt();
        Console.WriteLine("A(" + xA + ";" + yA + ") and B(" + xB + ";" + yB + ")");
        Console.WriteLine("Dovzhina: " + P);
        Console.WriteLine("Kyt: " + S);
    }
}