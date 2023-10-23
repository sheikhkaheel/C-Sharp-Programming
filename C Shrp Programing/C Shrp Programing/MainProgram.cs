using System;
using System.Threading;

namespace C_Shrp_Programing
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed from Main");
            NameSum Name = new NameSum();
            Table Tbl = new Table();
            Loop rep = new Loop();
            Star ptr = new Star();
            Time Count = new Time();
            Tbl.Form();
            Name.Symbol();
            rep.Continue();
            ptr.Pattners();
            Count.Clock();
        }
    }
}

class NameSum
{
    public void Symbol()
    {
        char ض = 'k';
        char x2 = 'a';
        char x3 = 'h';
        char x4 = 'e';
        char x5 = 'e';
        char x6 = 'l';
        int result = (int)ض + (int)x2 + (int)x3 + (int)x4 + (int)x5 + (int)x6;
        Console.WriteLine($"Sum of Kaheel {result} and Unicode symbol {(char)result}");
    }
}

class Table
{
    public void Form()
    {
        Console.WriteLine("Table");
        Console.WriteLine("Id\tName\tAddress \tAge");
        Console.WriteLine("0\tKaheel\tIllahi Bagh\t20");
        Console.WriteLine("1\tZaid\tIllahi Bagh\t20");
        Console.WriteLine("2\tZubair\tIllahi Bagh\t23");
    }
}

class Loop
{
    public void Continue()
    {
        int x = 10;
        int y = x++;
        Console.WriteLine($"Using Post operator x,y {x} and {y}");
        y = ++x;
        Console.WriteLine($"Using Pre operator x,y {x} and {y}");
        Console.WriteLine("If Else");
        int a = 10, b = 12;
        if (a > b)
        {
            Console.WriteLine("A is greater");
        } else
        {
            Console.WriteLine("Bit is greater");
        }
        Console.WriteLine("Loop");
        int loop = 2, num = 1;
        while (num <= 10)
        {
            int mul = loop * num;
            Console.WriteLine($"{loop} * {num} = {mul}");
            num++;
        }
        Console.WriteLine("Switch Statement");
        int check = 1;
        switch (check)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Defult");
                break;

        }
    }
}

public class Time
{
    public void Clock()
    {
        for (int hour = 0; hour <= 23; hour++)
        {
            for (int min = 0; min <= 59; min++)
            {
                for (int sec = 0; sec <= 59; sec++)
                {
                    Console.SetCursorPosition(60,0);
                    Console.WriteLine($"Time {hour:D2}:{min:D2}:{sec:D2}"); 
                    Thread.Sleep(1000); 
                }
            }
        }
    }

}

class Star
{
    public void Pattners()
    {
        for(int i = 0; i<5; i++)
        {
            for(int j = 0; j<i+1; j++)
            {
                string str = "* ";
                Console.Write(str);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                string str = "* ";
                Console.Write(str);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                string space = " ";
                Console.Write(space);
            }
            for (int j = i; j < 5; j++)
            {
                string str = "* ";
                Console.Write(str);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                string space = " ";
                Console.Write(space);
            }
            for (int j = 0; j < i + 1; j++)
            {
                string str = "* ";
                Console.Write(str);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                if (i == 0 || i == 4 || j == 0 || j == 4)
                {
                    string str = "* ";
                    Console.Write(str);
                } else
                {
                    string space = "  ";
                    Console.Write(space);
                }
            }
            Console.WriteLine();
        }
    }

}