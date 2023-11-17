using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shrp_Programing
{
    // Abstract class
    public abstract class Shape
    {
        // Abstract method (no implementation in the base class)
        public abstract double CalculateArea();

        // Regular method with implementation
        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    // Derived class inheriting from the abstract class
    public class Circle : Shape
    {
        // Implementation of the abstract method
        public override double CalculateArea()
        {
            // Calculate the area of a circle
            // (This is just a placeholder formula, the actual implementation may vary)
            return Math.PI * Math.Pow(radius, 2);
        }

        // Additional members specific to the Circle class
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }

    /*class Program
    {
        static void Main()
        {
            // You cannot create an instance of an abstract class
            // Shape shape = new Shape(); // This will result in a compilation error

            // But you can create instances of classes derived from the abstract class
            Circle circle = new Circle(5);
            circle.Display(); // Calls the Display method from the base class
            double area = circle.CalculateArea(); // Calls the overridden method in the derived class
            Console.WriteLine($"Area of the circle: {area}");
        }
    }*/

}
