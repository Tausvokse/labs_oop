using System;
using System.Text.RegularExpressions;

class BaseString
{
    protected string str;

    public BaseString(string str)
    {
        this.str = str;
    }

    public int Length()
    {
        return str.Length;
    }
}

class LetterString : BaseString
{
    public LetterString(string str) : base(str)
    {
        string pattern = "[^a-zA-Z]";
        string replacement = "";
        Regex regex = new Regex(pattern);
        this.str = regex.Replace(str, replacement);
    }

    public void Sort()
    {
        char[] chars = str.ToCharArray();
        Array.Sort(chars, 0, str.Length);
        str = new string(chars);
    }

    public string GetString()
    {
        return str;
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
            Console.WriteLine("Enter string value:");
            LetterString s = new LetterString(Console.ReadLine());
            Console.WriteLine("String: " + s.GetString());
            Console.WriteLine("Length: " + s.Length());
            s.Sort();
            Console.WriteLine("Sorted: " + s.GetString());
            Console.WriteLine("Do you want to restart? Yes - 'Y', No - 'N'. Press 'S' to exit.");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "n")
            {
                restart = false;
            } else if(answer.ToLower() == "s")
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Black;
                Environment.Exit(0);
            }
        }
    }
}