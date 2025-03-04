using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4Q_1
{
    internal class Book
    {
        public string title;
        public string Author;
        public string ISBN;
        public double price;

        public void DisplayBookInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\tBook details are as follow:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book Price: {price}");
        }
        public void ApplyDiscount(double percentage)
        {
            if (percentage > 0 && percentage <= 100)
            {
                price -= price * (percentage / 100);
                Console.WriteLine($"New Price: {price}");
            }
            else
            {
                Console.WriteLine("Invalid discount percentage.");
            }
        }
    }
}
