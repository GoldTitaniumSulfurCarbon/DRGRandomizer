using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DRGRandomizer
{
    internal class Driller
    {
        //Names of all weapons to use as reference
        private string[] primaries = { "Flamethrower", "Cryo Cannon", "Sludge Launcher" };
        private string[] secondaries = { "Subata", "Plasma Charger", "Wave Cooker" };
        private string[] grenades = { "Throwing Axe", "Neurotoxin", "HE Grenade", "Springloaded Ripper" };


        public override string ToString()
        {
            return string.Format($"{PrimaryRandomizer()}\n" +
                $"{SecondaryRandomizer()}\n" +
                $"{GrenadeRandomizer()}\n" +
                $"{PDrillRandomizer()}\n" +
                $"{PickaxeRandomizer()}\n" +
                $"{SatchelRandomizer()}\n" +
                $"{ArmorRandomizer()}");
        }
        public string PrimaryRandomizer()
        {
            StringBuilder output = new StringBuilder("Primary: ");
            Random rand = new Random();
            string[] tiers = new string[7]; //Index 0 is the name, index 1-5 are tiers, intentially done to make them one-indexed, index 6 is overclock

            int length = tiers.Length;
            string [] tiersNum = { "1", "2", "3" };
            string[] names = this.primaries;
            string[,] overclocks =
            {
                {"Lighter Tanks", "Sticky Additive", "Compact Feed Valves", "Fuel Stream Diffuser","Face Melter", "Sticky Fuel"},
                {"Improved Thermal Efficiency", "Tuned Cooler", "Flow Rate Expansion", "Ice Spear", "Ice Storm", "Snowball"},
                {"Hydrogen Ion Additive", "AG Mixture", "Volatile Impact Mixture", "Dispenser Compound", "Goo Bomber Special", "Sludge Blast"}
            };


            int randomP = rand.Next(3); //Randomizes weapon
            tiers[0] = names[randomP]; //Gets name for that weapon
            if (randomP == 0) //Conditionals used for weapons that have different amount of upgrades at each tier
                tiers[1] = tiersNum[rand.Next(2)]; //crispr
            else
                tiers[1] = tiersNum[rand.Next(3)]; //cryo and sludge

            tiers[2] = tiersNum[rand.Next(3)];
            if (randomP == 0)
                tiers[3] = tiersNum[rand.Next(3)]; //crispr
            else
                tiers[3] = tiersNum[rand.Next(2)]; //cryo and sludge
            if (randomP == 2)
                tiers[4] = tiersNum[rand.Next(2)]; //sludge
            else
                tiers[4] = tiersNum[rand.Next(3)]; //crispy and cryo
            tiers[5] = tiersNum[rand.Next(2)];
            tiers[6] = overclocks[randomP,rand.Next(6)];

            foreach (string t in tiers)
            { //traverses array and adds to a string value to display horizontally
                output.Append(t + ", ");
            }

            output.Remove(output.Length-2,1); //gets rid of comma for last section after switching to foreach 
            return output.ToString();
        }
        public string SecondaryRandomizer()
        {
            StringBuilder output = new StringBuilder("Secondary: ");
            Random rand = new Random();
            string[] tiers = new string[7];
            string[] names = this.secondaries;
            string[]tierNum = { "1", "2", "3"};
            string[,] overclocks =
            {
                {"Chain Hit", "Homebrew Powder", "Oversized Magazine", "Oversized Magazine", "Explosive Reload", "Tranquilizer Rounds"},
                {"Energy Rerouting", "Magnetic Cooling Unit", "Heat Pipe", "Heavy Hitter", "Overcharger", "Persistent Plasma"},
                {"Liquid Cooling System", "Super Focus Lens", "Diffusion Ray", "Mega Power Supply", "Blisterng Necrosis", "Gamma Contamination"}
            };
            
            int randomSecondary = rand.Next(3);
            tiers[0] = names[randomSecondary]; //gets name
            tiers[1] = tierNum[rand.Next(3)]; //gets random tier 1; since all Driller secondaries have three different T1 upgrades no need to adjust
            if (randomSecondary == 2) //gets random tier 2 depending on what the value of randomSecondary is
                tiers[2] = tierNum[rand.Next(3)]; //wave cooker
            else
                tiers[2] = tierNum[rand.Next(2)]; //subata and charger

            if (randomSecondary == 2) //tier 3
                tiers[3] = tierNum[rand.Next(2)]; //wave cooker
            else
                tiers[3] = tierNum[rand.Next(3)]; //subata and charger

            if (randomSecondary == 1) //tier 4; checks for plasma charger
                tiers[4] = tierNum[rand.Next(3)]; //charger
            else
                tiers[4] = tierNum[rand.Next(2)]; //subata and cooker

            if (randomSecondary == 0) //tier 5; checks for subata
                tiers[5] = tierNum[rand.Next(3)]; //subata
            else
                tiers[5] = tierNum[rand.Next(2)]; //charger and cooker

            tiers[6] = overclocks[randomSecondary, rand.Next(6)]; //gets overclock

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
       
        public string PDrillRandomizer()
        {
            StringBuilder output = new StringBuilder("Power Drill: ");
            Random rand = new Random();
            int[] tiers = new int[4];
            tiers[0] = rand.Next(3) + 1;
            tiers[1] = rand.Next(2) + 1;
            tiers[2] = 1;
            tiers[3] = rand.Next(2) + 1;
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

        public string SatchelRandomizer()
        {
            StringBuilder output = new StringBuilder("Satchel Charge: ");
            Random rand = new Random();
            int[] tiers = new int[4];
            tiers[0] = rand.Next(3) + 1;
            tiers[1] = 1;
            tiers[2] = rand.Next(3) + 1;
            tiers[3] = rand.Next(2) + 1;

            foreach (int t in tiers)
            {
                output.Append(t + ", ");
            }
            output.Remove(output.Length - 2, 1);
            return output.ToString();
        }

        public string ArmorRandomizer()
        {
            StringBuilder output = new StringBuilder ("Armor: ");
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
