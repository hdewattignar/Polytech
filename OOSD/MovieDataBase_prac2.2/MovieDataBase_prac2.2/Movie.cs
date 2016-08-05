using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataBase_prac2._2
{
    public class Movie
    {
        public int Year { get; set; }

        public String Title { get; set; }

        public String Director { get; set; }

        public Movie(int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            return Year.ToString() + ", " + Title + ", " + Director;
        }

        
    }
}
