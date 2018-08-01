using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie//This class/added classes toll you what to do specifically with each instance.
    {
        private readonly string _title;
        private readonly string _category;

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }


        public string Title { get { return _title; } }

        public string Category
        {
            get { return _category; }
        }
    }
}