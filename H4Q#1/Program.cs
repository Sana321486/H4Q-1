using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4Q_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "OOP";
            book.Author = "Ahsan";
            book.ISBN = "56783";
            book.price = 300;
            book.DisplayBookInfo();
            Console.Write("Enter discount percentage: ");
            double discount = Convert.ToDouble(Console.ReadLine());
            book.ApplyDiscount(discount);
            book.DisplayBookInfo();

        } 
    }
}
