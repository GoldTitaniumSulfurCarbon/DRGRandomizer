using static System.Console;
namespace DRGRandomizer

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Which one is more efficient? declaring outside of loop, or calling new instance inside of class, where a new class isn't designed.
            Driller D = new Driller();
            Engineer E = new Engineer();
            Gunner G = new Gunner();
            Scout S = new Scout();
            char input = ' ';
            while ((input!='a')&& (input != 'b') && (input != 'c') && (input != 'd') && (input != 'q'))
            {
                WriteLine("Please put in a number for the Dwarf you want to randomize.\n\"a\" for Scout\n\"b\" for Gunner\n\"c\" for Engineer\n\"d\" for Driller\n\"e\" for a random dwarf\n\"q\" to quit. ");
                input = ReadKey().KeyChar;
                
                WriteLine("\n\n"); //to give space
                if (input == 'a')
                    WriteLine(S);
                if (input == 'b')
                    WriteLine(G);
                if (input == 'c')
                    WriteLine(E);

                if (input == 'd')
                    WriteLine(D);
                if (input == 'e')
                {
                    int RandomDwarf = new Random().Next(3);
                    if (RandomDwarf == 0) //Driller
                        WriteLine(D);
                    if (RandomDwarf == 1) //Engineer
                        WriteLine(E);
                    if (RandomDwarf == 2) //Scout
                        WriteLine(S);

                }
                WriteLine("\n\n");

                if (input != 'q') {
                    if (!((input == 'a') || (input == 'b') || (input == 'c') || (input == 'd') || (input == 'e')))
                        WriteLine(input + " is invalid input");
                        input = ' ';
                }
                
            }
        }
    }
}