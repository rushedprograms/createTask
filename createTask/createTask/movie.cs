using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace createTask
{
    public class movie
    {
        public String name;
        public int availableCopies;
        private int totalCopies;
        public String rentee;
        private String address;
        public DateTime dueDate;
        public decimal price;
        public movie(String newName, decimal nPrice)
        {

            name = newName;
            availableCopies = 1;
            rentee = "no one";
            price = nPrice;
            dueDate = DateTime.Today.AddDays(7);
        }
        public void rent(String Rentee, String inputAddress)
        {
            dueDate = DateTime.Today.AddDays(7);
            rentee = Rentee;
            address = inputAddress;
            availableCopies -=1;
        }
        public void returnMovie()
            {
                if (availableCopies < totalCopies)
                {
                    availableCopies += 1;
                }
            rentee = "No one";
            address = "";
            dueDate = DateTime.Now;

            }
    }
}
