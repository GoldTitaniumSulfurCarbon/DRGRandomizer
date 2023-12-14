using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DRGRandomizer
{
    internal class Scout

    {
        private string[] primaries = { "Deepcore KG2", "M1000 Classic", "Plasma Carbine" };
        private string[] secondaries = { "Boomstick", "Zhukov", "Boltshark" };
        private string[] grenades = { "IFG", "Cryo Grenade", "Pheromone Canister", "Stun Sweeper" };

        public override string ToString()
        {
            return string.Format($"{PrimaryRandomizer()}\n" +
                $"{ SecondaryRandomizer()}" +
                $"\n{GrenadeRandomizer()}" +
                $"\n{GHookRandomizer()}" +
                $"\n{ PickaxeRandomizer()}" +
                $"\n{FGunRandomizer()}" +
                $"\n{ArmorRandomizer()}");
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
                {"Compact Ammo", "Gas Rerouting", "Homebrew Powder", "Overclocked Firing Mechanism","Bullets of Mercy", "AI Stability Engine", "Electrifying Reload"},
                {"Hoverclock", "Minimal Clips", "Active Stability System", "Hipster", "Electrocuting Focus Shots", "Supercooling Chamber", null},
                {"Aggressive Venting", "Thermal Liquid Coolant", "Impact Deflection", "Rewiring Mod", "Overtuned Particle Accelerator", "Shield Battery Booster", "Thermal Exhaust Feedback"}
            };
            int randomP = rand.Next(3);
            tiers[0] = names[randomP];

            if (randomP == 1) //M1000
                tiers[1] = tiersNum[rand.Next(2)];
            else
                tiers[1] = tiersNum[rand.Next(3)];
            if (randomP == 1)
                tiers[2] = tiersNum[rand.Next(3)];
            else
                tiers[2] = tiersNum[rand.Next(2)];
            if (randomP == 2) //DRAK
                tiers[3] = tiersNum[rand.Next(3)];
            else
                tiers[3] = tiersNum[rand.Next(2)];
            if (randomP == 2)
                tiers[4] = tiersNum[rand.Next(3)];
            else
                tiers[4] = tiersNum[rand.Next(2)];
            if (randomP == 2)
                tiers[5] = tiersNum[rand.Next(2)];
            else
                tiers[5] = tiersNum[rand.Next(3)];

            if (randomP == 1) //M1000 only has 6 overclocks, where the other two have seven
                tiers[6] = overclocks[randomP, rand.Next(6)];
            else
                tiers[6] = overclocks[randomP, rand.Next(7)];


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
            string[] tiersNum = { "1", "2", "3" };
            string[] names = this.secondaries;
            string[,] overclocks =
            {
                {"Compact Shells", "Double Barrel", "Special Powder", "Stuffed Shells", "Shaped Shells", "Jumbo shells" },
                {"Minimal Magazines", "Custom Casings", "Cryo Minelets", "Embedded Detonators", "Gas Recycling", null },
                {"Quick Fire", "The Specialist", "Cryo Bolt", "Fire Bolt", "Bodkin Points",  "Trifork Volley"}

            };
            int randomS = rand.Next(3);
            tiers[0] = names[randomS]; //gets name
            if (randomS == 2) //Crossbow
                tiers[1] = tiersNum[rand.Next(3)];
            else
                tiers[1] = tiersNum[rand.Next(2)];
            if (randomS == 0) //Boomstick
            {
                tiers[2] = tiersNum[rand.Next(2)];
                tiers[3] = tiersNum[rand.Next(3)];
            }
            else
            {
                tiers[2] = tiersNum[rand.Next(3)];
                tiers[3] = tiersNum[rand.Next(2)];
            }
            if (randomS == 2)
                tiers[4] = tiersNum[rand.Next(2)];
            else
                tiers[4] = tiersNum[rand.Next(3)];
            if (randomS == 1)
                tiers[5]= tiersNum[rand.Next(2)];
            else
                tiers[5] = tiersNum[rand.Next(3)];
            if (randomS == 1)
                tiers[6] = overclocks[randomS,rand.Next(5)];
            else
                tiers[6] = overclocks[randomS,rand.Next(6)];

            foreach (string t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }


            public string GrenadeRandomizer()
        {
            return "Grenade: " + grenades[new Random().Next(grenades.Length)];
        }
        public string GHookRandomizer()
        {
            StringBuilder output = new StringBuilder("Grappling Hook: ");
            Random rand = new Random();
            int[] tiers = new int[4];
            tiers[0] = rand.Next(2) + 1;
            tiers[1] = 1;
            tiers[2] = rand.Next(2) + 1;
            tiers[3] = rand.Next(3) + 1;
            foreach (int t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }

        public string PickaxeRandomizer()
        {
            string t2 = (new Random().Next(3) + 1).ToString(); //because there's only one tier of pickaxe upgrades, there's no need for an array.
            return "Pickaxe: 1, " + t2;

        }

        public string FGunRandomizer()
        {
            StringBuilder output = new StringBuilder("Flare Gun: ");
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
