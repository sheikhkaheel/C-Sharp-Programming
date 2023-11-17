using System;

namespace Wazawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Executed \n");
            TotalMeat tm = new TotalMeat();
            Spices sp = new Spices();
            NONVeg nvg = new NONVeg();
            Veg vg = new Veg();
            tm.setPeople(400);
            nvg.setMeat(); 
            tm.setTrame();
            nvg.CalMeat();
            tm.getTrame();
            nvg.CalVegs();
            vg.setVegPerTrame();
            vg.getVegPerTrame();
            vg.getTotalVeg();
            sp.CalSpices();
        }
    }
    public class TotalMeat
    {
        protected static int people;
        private int trames;

        public void setPeople(int People)
        {
            people = People;
        }
        public void setTrame()
        {
            trames = people / 4;
        }

        public void getTrame()
        {
            Console.WriteLine($"Trames \n {trames}");
        }
    }
    public class NONVeg : TotalMeat
    {
        private int ristaT = 100, gostabaT = 140, kababT = 80, chickenT = 140, tabakNateenT = 100, kormaT = 80, roganJoshT = 90, abbeGoshT = 120;
        private int rista, gostaba, kabab, chicken, tabakNateen, korma, roganJosh, abbeGosh;
        public int meat;
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

        public void setMeat()
        {
            meat = ristaT + gostabaT + kababT + chickenT + tabakNateenT + kormaT + roganJoshT + abbeGoshT;
            Console.WriteLine($"NonVeg per Trame \n {meat}g");
        }

        public void CalMeat()
        {
            int totalMeat = this.meat * people;
            Console.WriteLine($"Total NonVeg \n {totalMeat / 1000}kg");
        }
    }

    public class Veg : TotalMeat
    {
        private int palak, chaman, haakh;
        private int palakT = 50, chamanT = 60, haakhT = 40;
        private int VegT,Veggy;
        public void setVegPerTrame()
        {
            palak = people * palakT;
            chaman = people * chamanT;
            haakh = people * haakhT;
            Console.WriteLine($"Veg \n Palak {palak/1000}kg Chaman {chaman/1000}kg Haakh {haakh/1000}kg");
        }

        public void getVegPerTrame()
        {
            VegT = palakT + chamanT + haakhT;
            Console.WriteLine($"Veg per trame \n { VegT}g");
            Veggy = palak + chaman + haakh;
        }

        public void getTotalVeg()
        {
            int totalVeg = people * this.Veggy/1000;
            Console.WriteLine($"Total Veg \n {totalVeg/1000}kg");
        }
    }

    public class Spices : TotalMeat
    {
        private float fennelSeeds, dryGinger, cloves, cinnamon, cardamom, asafoetida, redChiliPowder, turmeric, mustardOil;
        private float fennelSeedsT = 2, dryGingerT = 3, clovesT = 1, cinnamonT = 1.5f, cardamomT = 2, asafoetidaT = 2, redChiliPowderT = 6, turmericT = 6, mustardOilT = 30;

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
            Console.WriteLine($"Spices \n FennelSeeds {fennelSeeds / 1000}kg, DryGinger {dryGinger / 1000}kg, Cloves {cloves / 1000}kg, Cinnamon {cinnamon / 1000}kg, Cardamom {cardamom / 1000}kg, Asafoetida {asafoetida / 1000}kg, RedChiliPowder {redChiliPowder / 1000}kg, Turmeric {turmeric / 1000}kg, MustardOil {mustardOil}kg");
        }
    }
}
