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
    public partial class managerMenu : Form
    {
        void updateMenu()
        {
            list.Items.Clear();

            foreach (movie x in Form1.movies)
            {
                list.Items.Add(x.name + " checked out by " + x.rentee);
            }
        }
        public managerMenu()
        {
            InitializeComponent();
        }

        private void managerMenu_Load(object sender, EventArgs e)
        {
            updateMenu();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            Form1.movies.Add(new movie(movieName.Text, Decimal.Parse(moviePrice.Text)));
           
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            Form1.movies.Add(new movie(movieName.Text, Decimal.Parse(moviePrice.Text)));
            updateMenu();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 managerForm = new Form1();
            managerForm.Visible = true;
        }
    }
}
