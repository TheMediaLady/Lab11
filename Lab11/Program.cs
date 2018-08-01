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

            
            bool response = true;
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Star Wars", "SciFi"));
            movieList.Add(new Movie("2001: A Space Odyssey ", "SciFi"));
            movieList.Add(new Movie("E.T. The Extra-terrestrial", "SciFi"));
            movieList.Add(new Movie("A Clockwork Orange", "SciFi"));
            movieList.Add(new Movie("Close Encounters of the Thir Kind", "SciFi"));
            movieList.Add(new Movie("Jungle Book", "Animated"));
            movieList.Add(new Movie("Aristocats", "Animated"));
            movieList.Add(new Movie("Bullwinkle", "Animated"));
            movieList.Add(new Movie("The Pursuit of Happyness", "Drama"));
            movieList.Add(new Movie("Fight Club", "Drama"));
            movieList.Add(new Movie("The Godfather", "Drama"));
            movieList.Add(new Movie("Halloween", "Horror"));
            movieList.Add(new Movie("Friday the 13th", "Horror"));
            movieList.Add(new Movie("Jaws", "Horror"));
            

            while (response)
            {
                Console.WriteLine($"There are {movieList.Count} movies in this list");
                Console.WriteLine("What category are you interested in?");

                string answer = Console.ReadLine();
                answer = answer.ToLower();
                foreach (Movie movie in movieList)
                { //i.e. DVD stack = DVD stack is the movieList, movie is the DVD itself & Title is the title
                    if (movie.Category.ToLower() == answer)
                    {
                        Console.WriteLine(movie.Title);
                    }
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
