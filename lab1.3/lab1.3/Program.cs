using lab1._1_1;
using System;
using String = lab1._1_1.String;

namespace Task3
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            String first = new String("hi");
            String second = new String(" world");

            Console.WriteLine("1) String + char");
            Console.WriteLine("Операнд1 = " + first.getstr);
            Console.WriteLine("Операнд2 = B");

            char a = 'B';
            String res = first + a;

            Console.WriteLine("Результат  = " + res.getstr + "\n");
          
            Console.WriteLine("1) char + String");
            Console.WriteLine("Операнд1 = B");
            Console.WriteLine("Операнд2 = " + first.getstr);

            res = a + first;
            Console.WriteLine("Результат = " + res.getstr + "\n");

            Console.WriteLine("3) String + String");

            Console.WriteLine("Операнд1 = " + first.getstr);
            Console.WriteLine("Операнд2 = " + second.getstr);
            res = first + second;
            Console.WriteLine("Результат = " + res.getstr + "\n");

            Console.WriteLine("4) String >= String");

            Console.WriteLine("Операнд1 = " + first.getstr);
            Console.WriteLine("Операнд2 = " + second.getstr);
            bool сomp = first >= second;
            Console.WriteLine("Результат операцiї = " + сomp + "\n");

            Console.WriteLine("5) String++");
            Console.WriteLine("Oперанд = " + first.getstr);
            res = ++first;
            Console.WriteLine("Результат = " + res.getstr + "\n");

            Console.WriteLine("6) False (Якщо усi закритi поля = 0)");
            Console.WriteLine("Oперанд1 = " + second.getstr);
            Console.Write("Результат = ");
            if (second)
            {
                Console.WriteLine("true (всi закритi поля = 0)");
            }
            else
            {
                Console.WriteLine("false (жоднi закритi поля = 0)");
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
