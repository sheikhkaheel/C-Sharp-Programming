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
            Prime number = new Prime();
            Person kaheel = new Person();
            Student person = new Student();
            Traingle tr = new Traingle();
            Length ln = new Length();
            Plan Square = new Plan();
            /*Tbl.Form();
            Name.Symbol();
            rep.Continue();
            ptr.Pattners();
            number.num = 10;
            bool check = number.isPrime();
            if (check == true)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
            kaheel.setVal("kaheel", "Illahi Bagh");
            kaheel.getVal();
            person.setVal();
            person.getVal();
            tr.SetAreaOfTraingle(5, 3);
            Console.WriteLine($"{tr.GetAreaOfTraingle()}");*/
            Count.Clock();
            Square.Length = 4;
            Square.Breadth = 4;
            Console.WriteLine(Square.Length);
            Console.WriteLine(Square.Breadth);
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
        int loop = 5, num = 1;
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

public class Prime
{
    public int num;
    private bool flag = true;
    public bool isPrime()
    {
        int k = 2;
        while (k<num/2)
        {
            if(num % k == 0)
            {
                flag = false;
                return flag;
            }
            k++;
        }
        return flag;
    }
}

public class Person
{
    public string Name;
    private int Age = 21;
    public string Address;
    public void setVal(string name , string address)
    {
        Name = name;
        Address = address;
    }
    public void getVal()
    {
        Console.WriteLine($"Person name is {Name} , age is {Age} and old address {Address}");
    }
}

public class Student
{
    public string Name;
    private int Age = 21;
    public string Address;
    public void setVal()
    {
        setActVal();
    }
    public void setActVal()
    {
        this.Name = "kaheel";
        this.Address = "Hawal";
    }
    public void getVal()
    {
        Console.WriteLine($"Person name is {Name} , age is {Age} and address {Address}");
    }
}

public class Traingle {
    private int height;
    private int length;
    public void SetAreaOfTraingle(int Length, int Height)
    {
        this.length = Length;
        this.height = Height;
    }
    public double GetAreaOfTraingle()
    {
        double area = (0.5 * length * height);
        return area;
    }
}

public class Length
{
    public int Lenght { set; get; }
}

public class Plan
{
    private int length; // Private backing field for Length
    private int breadth; // Private backing field for Breadth

    public int Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value > 0)
            {
                length = value;
            }
            else
            {
                Console.WriteLine("Length should be greater than 0");
            }
        }
    }

    public int Breadth
    {
        get
        {
            return breadth;
        }
        set
        {
            if (value > 0)
            {
                breadth = value;
            }
            else
            {
                Console.WriteLine("Breadth should be greater than 0");
            }
        }
    }
}
