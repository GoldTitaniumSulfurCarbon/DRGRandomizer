using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DRGRandomizer
{ 
    //maybe try to use lists and try multidimentional lists/
    internal class Engineer
    {

        private string[] primaries = { "Warthog Auto Shotgun", "Stubby SMG", "LOK-1 Rifle" }; // OVC: 5, 6, 6
        private string[] secondaries = { "Deepcore", "Breach Cutter", "Shard Diffractor" };
        private string[] grenades = { "LURE", "Plasma Burster", "Proximity Mine", "Shredder Swarm" };



        public override string ToString()
        {
            return string.Format($"{PrimaryRandomizer()}\n" +
                $"{SecondaryRandomizer()}\n" +
                $"{GrenadeRandomizer()}\n" +
                $"{SentryRandomizer()}\n" +
                $"{PickaxeRandomizer()}\n" +
                $"{PGunRandomizer()}\n" +
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
                {"Stunner", "Light-Weight Magazines", "Magnetic Pellet Alignment", "Cycle Overload", "Mini Shells", null},
                {"Super-slim Rounds", "Well Oiled Machine", "EM Refire Booster", "Light-Weight Rounds", "Turret Arc", "Turret EM Discharge"},
                {"Eraser", "Armor Break Module", "Explosive Chemical Rounds","Seeker Rounds", "Executioner", "Neuro-Lasso" }

            };
            int randomP = rand.Next(3);
            tiers[0] = names[randomP];
            if (randomP == 1)
                tiers[1] = tiersNum[rand.Next(3)]; //stubby
            else
                tiers[1] = tiersNum[rand.Next(2)]; //warthog and lok-1

            tiers[2] = tiersNum[rand.Next(3)];
            if (randomP == 1)
                tiers[3] = tiersNum[rand.Next(2)]; //stubby
            else
                tiers[3] = tiersNum[rand.Next(3)]; //warthog and lok-1
            if (randomP == 0)
                tiers[4] = tiersNum[rand.Next(3)]; //warthog
            else
                tiers[4] = tiersNum[rand.Next(2)]; //stubby and lok-1
            if (randomP == 2)
                tiers[5] = tiersNum[rand.Next(3)]; //lok-1
            else
                tiers[5] = tiersNum[rand.Next(2)]; //warthog and stubby
            if (randomP == 0)
                tiers[6] = overclocks[randomP, rand.Next(5)]; //warthog
            else
                tiers[6] = overclocks[randomP, rand.Next(6)]; //stubby and lok-1

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
            int length = tiers.Length;
            string[] tiersNum = { "1", "2", "3" }; //ovc: 6 7 6
            string[] names = this.secondaries;
            string[,] overclocks =
            {
                {"Clean Sweep", "Pack Rat", "Compact Rounds", "RJ250 Compound", "Fat Boy", "Hyper Propellant", null}, //deepcore
                {"Light-Weight Cases", "Roll Control", "Stronger Plasma Current", "Return to Sender", "High Voltage Crossover", "Spinning Death", "Inferno" }, //breach cutter
                {"Efficiency Tweaks", "Automated Beam Controller", "Feedback Loop", "Volatile Impact Reactor", "Plastcrete Catalyst", "Overdrive Booster", null} //diffractor
            };
            int randomS = rand.Next(3);
            tiers[0] = names[randomS];
            if (randomS == 1)
                tiers[1] = tiersNum[rand.Next(2)]; //breach
            else
                tiers[1] = tiersNum[rand.Next(3)]; //deepcore and diffractor
            if (randomS == 1)
                tiers[2] = tiersNum[rand.Next(3)]; //breach
            else
                tiers[2] = tiersNum[rand.Next(2)]; //deepcore and diffractor
            if (randomS == 0)
                tiers[3] = tiersNum[rand.Next(3)]; //deepcore
            else
                tiers[3] = tiersNum[rand.Next(2)]; //breach and diffractor
            if (randomS == 0)
                tiers[4] = tiersNum[rand.Next(3)]; //deepcore
            else
                tiers[4] = tiersNum[rand.Next(2)]; //breach and diffractor
            tiers[5] = tiersNum[rand.Next(3)];
            if (randomS == 1)
                tiers[6] = overclocks[randomS, rand.Next(7)]; //breach 
            else
                tiers[6] = overclocks[randomS, rand.Next(6)]; //deepcore and diffractor


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

        public string SentryRandomizer()
        {
            StringBuilder output = new StringBuilder("Sentry Gun: ");
            Random rand = new Random();
            int[] tiers = new int[4];
            tiers[0] = rand.Next(2) + 1;
            tiers[1] = rand.Next(3) + 1;
            tiers[2] = rand.Next(3) + 1;
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
        public string PGunRandomizer()
        {
            StringBuilder output = new StringBuilder("Platform Gun: ");
            Random rand = new Random();
            int[] tiers = new int[3];
            tiers[0] = rand.Next(3) + 1;
            tiers[1] = 1;
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
