using System;

namespace C_Shrp_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed from Main");
            NameSum Name = new NameSum();
            Table Tbl = new Table();
            Tbl.Form();
            Name.Symbol();
        }
    }
}

class NameSum
{
    public void Symbol()
    {
        char x1 = 'k';
        char x2 = 'a';
        char x3 = 'h';
        char x4 = 'e';
        char x5 = 'e';
        char x6 = 'l';
        int result = (int)x1 + (int)x2 + (int)x3 + (int)x4 + (int)x5 + (int)x6;
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