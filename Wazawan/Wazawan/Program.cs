using System;

namespace Wazawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed");
            TotalMeat tm = new TotalMeat();
            Veg vg = new Veg();
            vg.ExcessFields();
            vg.CalVegs();
            vg.setMeat(); // Call setMeat method to initialize meat value
            tm.CalMeat(vg.meat); // Pass the meat value to CalMeat
        }
    }

    public class Veg
    {
        private int ristaT = 100, gostabaT = 100, kababT = 70, chickenT = 80, tabakNateenT = 100, kormaT = 60, roganJoshT = 70, abbeGoshT = 120;
        private int rista, gostaba, kabab, chicken, tabakNateen, korma, roganJosh, abbeGosh;
        public int meat,people;
        public void CalVegs()
        {
            rista = ristaT * people;
            gostaba = gostabaT * people;
            kabab = kababT * people;
            chicken = chickenT * people;
            tabakNateen = tabakNateenT * people;
            korma = kormaT * people;
            roganJosh = roganJoshT * people;
            abbeGosh = abbeGoshT * people;
            Console.WriteLine($"Rista {rista/1000}kg , Gostaba {gostaba/1000}kg Kabab {kabab/1000}kg, chicken {chicken/1000}kg, TabakNateen {tabakNateen/1000}kg, Korma {korma/1000}kg , roganJosh {roganJosh/1000}kg , AbbeJosh {abbeGosh/1000}kg");
        }

        public void ExcessFields()
        {
            TotalMeat totalM = new TotalMeat();
            this.people = totalM.people;
        }

        
        public void setMeat()
        {
            meat = ristaT + gostabaT + kababT + chickenT + tabakNateenT + kormaT + roganJoshT + abbeGoshT;
            Console.WriteLine($"Meat per Trame {meat}g");
        }
    }

    public class TotalMeat
    {
        public int people = 100;

        public void CalTrame()
        {
            int trames = people / 4;
        }

        public void CalMeat(int vegMeat) // Accept the meat value as a parameter
        {
            int totalMeat = vegMeat * people;
            Console.WriteLine($"Total Meat {totalMeat/1000}kg");
        }
    }
}
