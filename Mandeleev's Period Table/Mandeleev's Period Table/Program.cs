using System;

namespace Mandeleev_s_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed");
            try
            {
                Console.WriteLine("Element      Atomic No   Atomic Mass");
                PeriodicTable obj1 = new PeriodicTable("Hydrogen", 1, 1.0079f);
                Console.WriteLine($"{obj1.ElementName,-12} {obj1.AtomicNumber,-12} {obj1.AtomicMass,-12}");

                PeriodicTable obj2 = new PeriodicTable("Helium", 2, 4.0026f);
                Console.WriteLine($"{obj2.ElementName,-12} {obj2.AtomicNumber,-12} {obj2.AtomicMass,-12}");

                PeriodicTable obj3 = new PeriodicTable("Lithium", 3, 6.941f);
                Console.WriteLine($"{obj3.ElementName,-12} {obj3.AtomicNumber,-12} {obj3.AtomicMass,-12}");

                PeriodicTable obj4 = new PeriodicTable("Beryllium", 4, 9.0122f);
                Console.WriteLine($"{obj4.ElementName,-12} {obj4.AtomicNumber,-12} {obj4.AtomicMass,-12}");

                PeriodicTable obj5 = new PeriodicTable("Boron", 5, 10.81f);
                Console.WriteLine($"{obj5.ElementName,-12} {obj5.AtomicNumber,-12} {obj5.AtomicMass,-12}");

                PeriodicTable obj6 = new PeriodicTable("Carbon", 6, 12.01f);
                Console.WriteLine($"{obj6.ElementName,-12} {obj6.AtomicNumber,-12} {obj6.AtomicMass,-12}");

                PeriodicTable obj7 = new PeriodicTable("Nitrogen", 7, 14.01f);
                Console.WriteLine($"{obj7.ElementName,-12} {obj7.AtomicNumber,-12} {obj7.AtomicMass,-12}");

                PeriodicTable obj8 = new PeriodicTable("Oxygen", 8, 16.00f);
                Console.WriteLine($"{obj8.ElementName,-12} {obj8.AtomicNumber,-12} {obj8.AtomicMass,-12}");

                PeriodicTable obj9 = new PeriodicTable("Fluorine", 9, 19.00f);
                Console.WriteLine($"{obj9.ElementName,-12} {obj9.AtomicNumber,-12} {obj9.AtomicMass,-12}");

                PeriodicTable obj10 = new PeriodicTable("Neon", 10, 20.18f);
                Console.WriteLine($"{obj10.ElementName,-12} {obj10.AtomicNumber,-12} {obj10.AtomicMass,-12}");

                PeriodicTable obj11 = new PeriodicTable("Sodium", 11, 22.99f);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class PeriodicTable
    {
        public string ElementName { get; set; }
        public int AtomicNumber { get; set; }
        public float AtomicMass { get; set; }

        private static int count = 0;

        public PeriodicTable(string elementName, int atomicNumber, float atomicMass)
        {
            if (count < 10)
            {
                count++;
                ElementName = elementName;
                AtomicNumber = atomicNumber;
                AtomicMass = atomicMass;
            }
            else
            {
                throw new Exception("Object can't be created beyond the limit.");
            }
        }
    }
}
