using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Programming");
            B obj2 = new B();
            obj2.add();
        }
    }
}

public class A
{
    public int Number { get; set; }
    public A()
    {
        Console.WriteLine("Constructer A");
    }
    public void add()
    {
        Console.WriteLine("A Method Called");
    }
}

public class B:A
{
    public B()
    {
        Console.WriteLine("Constructer B");
    }

    public void add()
    {
        Console.WriteLine("B Method Called");
    }
}