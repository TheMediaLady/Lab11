using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Movie List Application!");

            Console.WriteLine("There are 14 movies in this list");
            bool response = true;
            while (response)
            {
                Console.WriteLine("What category are you interested in?");

                string answer = Console.ReadLine();
                answer.ToLower();
                Movie type = new Movie(answer);

                string[] masterList = new string[14];
                masterList[0] = "Star Wars";
                masterList[1] = "2001: A Space Odyssey ";
                masterList[2] = "E.T. The Extra-terrestrial";
                masterList[3] = "A Clockwork Orange";
                masterList[4] = "Close Encounters of the Thirk Kind";
                masterList[5] = "Jungle Book";
                masterList[6] = "Aristocats";
                masterList[7] = "Bullwinkle";
                masterList[8] = "The Pursuit of Happyness";
                masterList[9] = "Fight Club";
                masterList[10] = "The Godfather";
                masterList[11] = "Halloween";
                masterList[12] = "Friday the 13th";
                masterList[13] = "Jaws";

                string[] movieCategory = new string[4];
                movieCategory[0] = "Animated";
                movieCategory[1] = "Drama";
                movieCategory[2] = "Horror";
                movieCategory[3] = "Scifi";

                if (answer == movieCategory[3])
                {
                    Console.WriteLine($"Movies are: \n {masterList[0]} \n {masterList[1]} \n {masterList[2]} \n {masterList[3]} \n {masterList[4]}");
                    Console.ReadLine();
                }
                else if (answer == movieCategory[0])
                {
                    Console.WriteLine($"Movies are: \n {masterList[5]} \n {masterList[6]} \n {masterList[7]}");
                    Console.ReadLine();
                }
                else if (answer == movieCategory[1])
                {
                    Console.WriteLine($"Movies are: \n {masterList[8]} \n {masterList[9]} \n {masterList[10]}");
                    Console.ReadLine();
                }
                else if (answer == movieCategory[2])
                {
                    Console.WriteLine($"Movies are: \n {masterList[11]} \n {masterList[12]} \n {masterList[13]}");
                    Console.ReadLine();
                }
                Console.WriteLine("Would you like to continue y/n?");
                string reply = Console.ReadLine();

                if (reply == "n")
                {
                    Console.WriteLine("Goodbye");
                    response = false;
                }
            }
            
        }
    }
}
