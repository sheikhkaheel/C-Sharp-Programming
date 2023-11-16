using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Programming");
            /*B obj2 = new B();
            obj2.add();*/
            A obj;
            obj = new B();
            if (obj is B)
            {
                B objB = (B)obj;
                objB.mul(); // Output: Method B from class B
            }
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
    public A(int a ,int b)
    {
        Console.WriteLine($"{a} , {b}");
    }
    public void add()
    {
        Console.WriteLine("A Method Called");
    }
}

public class B:A
{
    public B() : base(2,3)
    {
        base.add();
        Console.WriteLine("Constructer B");
    }
    public int mul()
    {
        return 2 * 2;
    }

    public void add()
    {
        Console.WriteLine("B Method Called");
    }
}