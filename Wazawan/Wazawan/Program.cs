using System;

namespace Wazawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed");
            TotalMeat tm = new TotalMeat();
            Spices sp = new Spices();
            NONVeg vg = new NONVeg();
            vg.ExcessFields();
            vg.CalVegs();
            vg.setMeat(); // Call setMeat method to initialize meat value
            tm.CalMeat(vg.meat); // Pass the meat value to CalMeat
            Console.WriteLine($"Total People \n {tm.people}");
            sp.Excess();
            sp.CalSpices();
        }
    }

    public class NONVeg
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
            Console.WriteLine($"NonVeg \n Rista {rista/1000}kg, Gostaba {gostaba/1000}kg, Kabab {kabab/1000}kg, chicken {chicken/1000}kg, TabakNateen {tabakNateen/1000}kg, Korma {korma/1000}kg , roganJosh {roganJosh/1000}kg , AbbeJosh {abbeGosh/1000}kg");
        }

        public void ExcessFields()
        {
            TotalMeat totalM = new TotalMeat();
            this.people = totalM.people;
        }

        
        public void setMeat()
        {
            meat = ristaT + gostabaT + kababT + chickenT + tabakNateenT + kormaT + roganJoshT + abbeGoshT;
            Console.WriteLine($"Meat per Trame \n {meat}g");
        }
    }

    public class Spices
    {
        private float fennelSeeds, dryGinger, cloves, cinnamon, cardamom, asafoetida, redChiliPowder, turmeric, mustardOil;
        private float fennelSeedsT = 2, dryGingerT = 3, clovesT = 1, cinnamonT = 1.5f, cardamomT = 2, asafoetidaT = 2, redChiliPowderT = 6, turmericT = 6, mustardOilT = 30;
        private int people;

        public void Excess()
        {
            TotalMeat totalM = new TotalMeat();
            this.people = totalM.people;
        }
        public void CalSpices()
        {
            fennelSeeds = people * fennelSeedsT;
            dryGinger = people * dryGingerT;
            cloves = people * clovesT;
            cinnamon = people * cinnamonT;
            cardamom = people * cardamomT;
            asafoetida = people * asafoetidaT;
            redChiliPowder = people * redChiliPowderT;
            turmeric = people * turmericT;
            mustardOil = people * mustardOilT;
            Console.WriteLine($"Spices \n FennelSeeds {fennelSeeds/1000}kg, DryGinger {dryGinger/1000}kg, Cloves {cloves/1000}kg, Cinnamon {cinnamon/1000}kg, Cardamom {cardamom/1000}kg, Asafoetida {asafoetida/1000}kg, RedChiliPowder {redChiliPowder/1000}kg, Turmeric {turmeric/1000}kg, MustardOil {mustardOil}kg");
        }
    }
    public class TotalMeat
    {
        public int people = 400;

        public void CalTrame() 
        { 
        
            int trames = people / 4;
        }

        public void CalMeat(int vegMeat) // Accept the meat value as a parameter
        {
            int totalMeat = vegMeat * people;
            Console.WriteLine($"Total Meat \n {totalMeat/1000}kg");
        }
    }
}
