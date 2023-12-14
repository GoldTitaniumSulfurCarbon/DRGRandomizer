using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRGRandomizer
{
    internal class Gunner
    {
        private string[] primaries = { "Minigun", "Autocannon", "Guided Rocket System" };
        private string[] secondaries = { "Heavy Revolver", "Burst Fire Gun", "Coil Gun" };
        private string[] grenades = { "Sticky Grenade", "Incendiary Grenade", "Cluster Grenade", "Tactical Leadburst" };


        public override string ToString()
        {
            return string.Format($"{PrimaryRandomizer()}\n" +
                $"{SecondaryRandomizer()}\n" +
                $"{GrenadeRandomizer()}\n" +
                $"{SGeneratorRandomizer()}\n" +
                $"{PickaxeRandomizer()}\n" +
                $"{ZLLauncherRandomizer()}\n" +
                $"{ArmorRandomizer()}");
        }



        public string PrimaryRandomizer()
        {
            StringBuilder output = new StringBuilder("Primary: ");
            Random rand = new Random();
            string[] tiers = new string[7];

            int length = tiers.Length;
            string[] tiersNum = { "1", "2", "3" };
            string[] names = this.primaries;
            string[,] overclocks =
            {
                {"A Little More Oomph!", "Thinned Drum Walls", "Burning Hell", "Compact Feed Mechanism", "Exhaust Vectoring", "Bullet Hell", "Lead Storm" }, //minigun
                {"Composite Drums", "Splintering Shells", "Carpet Bomber", "Combat Mobility", "Big Bertha","Neurotoxin Payload", null}, //autocannon
                {"Overtuned Feed Mechanism", "Fragmentation Missiles","Plasma Burster Missiles", "Minelayer System", "Rocket Barrage", "Jet Fuel Homebrew", "Salvo Module" } //GRS
            };

            int randomP = rand.Next(3);
            tiers[0] = names[randomP];
            tiers[1] = tiersNum[rand.Next(3)];
            if (randomP == 1) //autocannon
                tiers[2] = tiersNum[rand.Next(3)];
            else
                tiers[2] = tiersNum[rand.Next(2)]; //minigun and GRS
            if (randomP == 2) //GRS
                tiers[3] = tiersNum[rand.Next(2)];
            else
                tiers[3] = tiersNum[rand.Next(3)];
            if (randomP == 0) //minigun
                tiers[4] = tiersNum[rand.Next(3)];
            else
                tiers[4] = tiersNum[rand.Next(2)];
            tiers[5] = tiersNum[rand.Next(3)];
            if (randomP == 1)
                tiers[6] = overclocks[randomP, rand.Next(6)]; //autocannon
            else
                tiers[6] = overclocks[randomP, rand.Next(7)]; //minigun and GRS

            foreach (string t in tiers)
            { //traverses array and adds to a string value to display horizontally
                output.Append(t + ", ");
            }

            output.Remove(output.Length - 2, 1); //gets rid of comma for last section after switching to foreach 
            return output.ToString();
        }

        public string SecondaryRandomizer()
        {
            StringBuilder output = new StringBuilder("Secondary: ");
            Random rand = new Random();
            string[] tiers = new string[7];
            string[] names = this.secondaries;
            string[] tiersNum = { "1", "2", "3" };
            string[,] overclocks =
            {
                {"Chain Hit", "Homebrew Powder", "Volatile Bullets", "Six Shooter", "Elephant Rounds", "Magic Bullets", null}, //revolver
                {"Composite Casings", "Full Chamber Seal", "Compact Mags", "Experimental Rounds", "Electro Minelets", "Micro Flechettes", "Lead Spray" }, //burst
                {"Re-atomizer", "Ultra-Magnetic Coils", "Backfeeding Module", "The Mole", "Hellfire", "Triple-Tech Chambers", null} //coilgun
            };

            int randomS = rand.Next(3);
            tiers[0] = names[randomS];

            tiers[1] = tiersNum[rand.Next(3)];
            tiers[2] = tiersNum[rand.Next(3)];
            if (randomS == 0) //revolver
                tiers[3] = tiersNum[rand.Next(3)];
            else
                tiers[3] = tiersNum[rand.Next(2)];
            if (randomS == 2) //coilgun
                tiers[4] = tiersNum[rand.Next(2)];
            else
               tiers[4] = tiersNum[rand.Next(3)]; //revolver and burst
            if (randomS == 2) //coilgun
                tiers[5] = tiersNum[rand.Next(3)];
            else
                tiers[5] = tiersNum[rand.Next(2)]; //revolver and burst

            if (randomS == 1)
                tiers[6] = overclocks[randomS, rand.Next(7)]; //burst
            else
                tiers[6] = overclocks[randomS, rand.Next(6)]; //revolver and coil


            foreach (string t in tiers)
            { //traverses array and adds to a string value to display horizontally
                output.Append(t + ", ");
            }

            output.Remove(output.Length - 2, 1); //gets rid of comma for last section after switching to foreach 
            return output.ToString();
        }
    


        public string GrenadeRandomizer()
        {
            return "Grenade: " + grenades[new Random().Next(grenades.Length)];
        }

        public string PickaxeRandomizer()
        {
            string t2 = (new Random().Next(3) + 1).ToString(); //because there's only one tier of pickaxe upgrades, there's no need for an array.
            return "Pickaxe: 1, " + t2;

        }
        public string SGeneratorRandomizer()
        {
            StringBuilder output = new StringBuilder("Shield Generator: ");
            Random rand = new Random();
            int[] tiers = new int[3];
            tiers[0] = rand.Next(2) + 1;
            tiers[1] = rand.Next(2) + 1;
            tiers[2] = rand.Next(3) + 1;
            foreach (int t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }

        public string ZLLauncherRandomizer()
        {
            StringBuilder output = new StringBuilder("Zipline Launcher: ");
            Random rand = new Random();
            int[] tiers = new int[3];
            tiers[0] = rand.Next(3) + 1;
            tiers[1] = 1;
            tiers[2] = rand.Next(2) + 1;
            foreach (int t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }


        public string ArmorRandomizer()
        {
            StringBuilder output = new StringBuilder("Armor: ");
            Random rand = new Random();
            int[] tiers = new int[4];
            tiers[0] = rand.Next(3) + 1;
            tiers[1] = rand.Next(2) + 1;
            tiers[2] = 1;
            tiers[3] = rand.Next(3) + 1;


            foreach (int t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }
    }
}
