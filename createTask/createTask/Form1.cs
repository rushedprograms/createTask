using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace createTask
{
    public partial class Form1 : Form
    {
        public static  List<movie> movies;
        decimal debt = 0;
        int FindMovie(String name)
        {

            for (int x = 0; x < movies.Count; x++)
            {
                if (movies[x].name == name)
                {
                    return x;
                }
           
            }

           return -1;
        }
        void reserve()
        {

        }
        public Form1()
        {
            
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            managerMenu managerForm = new managerMenu();
            managerForm.Update();
            managerForm.Visible = true;
       
            
        }

        private void rent_Click(object sender, EventArgs e)
        {
            int movieIndex = FindMovie(movieChosen.Text);

            if (movieIndex == -1)
            {
                MessageBox.Show("That movie isn't in the database yet");
            }
            else if (movies[movieIndex].availableCopies == 0 )
            {
                MessageBox.Show("This isn't available right now"); 
            
            }

            else
            {
                movies[movieIndex].rent(nameBox.Text,addressBox.Text);
                debt += (movies[movieIndex].price * (decimal)1.05);
                amount.Text = string.Format("{0:C}", debt);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            int movieIndex = FindMovie(movieChosen.Text);
            if (DateTime.Today < movies[movieIndex].dueDate)
            {
                movies[movieIndex].returnMovie();
            }

            else if (DateTime.Today > movies[movieIndex].dueDate)
            {
                movies[movieIndex].returnMovie();
                amount.Text = string.Format("{0:C}", (10 * 1.05));
            }

            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (movies == null)
            {
                movies = new List<movie>();
                movies.Add(new movie("Pantypool", 13));
                movies.Add(new movie("Star Trek but Magic", 16));
                movies.Add(new movie("Starwars but Communist", 16));
                movies.Add(new movie("Memology", 20));
                movies.Add(new movie("Toy Story 7", 40));
            }
            movieChosen.Items.Clear();
            
            foreach (movie x in Form1.movies)
            {
                movieChosen.Items.Add(x.name + " checked out by " + x.rentee);
            }

        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            addressBox.Clear();
            amount.Text = "";
        }
    }
}
