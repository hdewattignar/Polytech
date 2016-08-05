using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDataBase_prac2._2
{
    public partial class Form1 : Form
    {

        Manager movieManager;

        public Form1()
        {
            InitializeComponent();

            movieManager = new Manager();
        }


        //print the key then the movie info
        private void Print(int year, String movieInfo)
        {            
            lb_PrintAllDisplay.Items.Add("---------------------------------------------------------------------------------------");
            lb_PrintAllDisplay.Items.Add(Convert.ToString(year));
            lb_PrintAllDisplay.Items.Add(movieInfo);
        }

        // takes in a message to show
        private void FeedbackMesage(String Message)
        {
            MessageBox.Show(Message);
        }        

        //print all the movies
        private void btn_PrintAll_Click(object sender, EventArgs e)
        {
            lb_PrintAllDisplay.Items.Clear();

            foreach (KeyValuePair<int, Movie> currentMovie in movieManager.getMovies())
            {
                Print(currentMovie.Key, currentMovie.Value.ToString());
            }
        }

        // add a movie if input is valid
        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            //get the text from the text boxes making sure the inout is valid type and length
            try
            {
                int year = 0;

                //dates must be 4 characters long
                if (txt_AddMovieYear.Text.Length == 4)
                {
                    year = Convert.ToInt32(txt_AddMovieYear.Text);
                }
                else
                    FeedbackMesage("Pleasr enter a valid year");

                String title = txt_AddMovieTitle.Text;
                String director = txt_AddMovieDirector.Text;

                movieManager.AddMovie(year, title, director);
            }

            //catches format exeption if nothing is in the text box
            catch (FormatException)
            {
                FeedbackMesage(txt_AddMovieYear.Text + " please provide valid input for all fields");
            }
            catch (ArgumentException)
            {
                FeedbackMesage(txt_AddMovieYear.Text + " already exists");
            }

            ClearFields();
        }

        //clear all fields
        private void ClearFields()
        {
            txt_AddMovieYear.Clear();
            txt_AddMovieTitle.Clear();
            txt_AddMovieDirector.Clear();
            txt_DeleteYear.Clear();
            txt_SearchYear.Clear();
        }


        //search movies by year/key
        private void btn_SearchMovie_Click(object sender, EventArgs e)
        {
            lb_PrintAllDisplay.Items.Clear();

            try
            {
                int key = Convert.ToInt32(txt_SearchYear.Text);

                //make sure there is an entry for the key the user has entered
                if (movieManager.getMovies().ContainsKey(key))
                {
                    Movie selectedMovie = movieManager.getMovie(key);
                    Print(selectedMovie.Year, selectedMovie.ToString());
                }
                else
                    FeedbackMesage(txt_SearchYear.Text + " could not be found");
            }
            catch(FormatException)
            {
                FeedbackMesage("please provide valid input for all fields");
            }

            ClearFields();
        }

        private void btn_DeleteMovie_Click(object sender, EventArgs e)
        {

            try
            {
                int key = Convert.ToInt32(txt_DeleteYear.Text);

                //make sure there is an entery for the key entered by the user
                if (movieManager.getMovies().ContainsKey(key))
                {
                    movieManager.DeleteMovie(key);
                    FeedbackMesage(txt_DeleteYear.Text + " successfully deleted");
                }
                else
                {
                    FeedbackMesage(txt_DeleteYear.Text + " could not be found");
                }
            }
            catch
            {
                FeedbackMesage("please provide valid input for all fields");
            }

            ClearFields();
        }
    }
}
