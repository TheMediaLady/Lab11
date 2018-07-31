using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        public string title { get; private set; }
        public string category { get; private set; }

        public Movie(string title)
        
       
        {
            this.title = title;
            this.category = category;
     
       
            
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
         


        }


        public string Names { get; set; }

        public string Category()
        {
            string[] movieCategory = new string[4];
            movieCategory[0] = "Animated";
            movieCategory[1] = "Drama";
            movieCategory[2] = "Horror";
            movieCategory[3] = "SciFi";

            return title;
            
        }
        
    }
}