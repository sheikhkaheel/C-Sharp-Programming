using System;

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
            Tbl.Form();
            Name.Symbol();
            rep.Continue();
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
        Console.WriteLine("Table");
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