using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataBase_prac2._2
{
    class Manager
    {

        SortedDictionary<int, Movie> movieTable { get; set; }

        public Manager()
        {
            movieTable = new SortedDictionary<int, Movie>();

            Movie movie1 = new Movie(1961, "WestSide Story", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
            Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);
        }

        //returns the dictionary of all movies
        public SortedDictionary<int, Movie> getMovies()
        {
            return movieTable;
        }

        //gets a movie from the dictionary 
        public Movie getMovie(int key)
        {
            
            return movieTable[key];
        }

        //adds a movie to the dictionary
        public void AddMovie(int year, String title, String director)
        {
            Movie movie = new Movie(year, title, director);
            movieTable.Add(movie.Year, movie);
        }

        //delete a movie from the dictionary
        public void DeleteMovie(int key)
        {            
            movieTable.Remove(key);             
        }
    }
}
