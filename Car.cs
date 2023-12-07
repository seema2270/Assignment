using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   

    public class Car
    {
        // Properties
        private string brand;
        private int year;
        private float price;

        // Constructor
        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        // Method to display car details
        public void DisplayCarDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: ${price}");
        }
    }

}
