using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4Q_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employeeID = 123;
            employee.name = "Ahsan";
            employee.department= "Computer Science";
            employee.salary = 300000;
            employee.DisplayEmployeeDetails();
            Console.Write("Enter increase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            employee.IncreaseSalary(amount);
            employee.DisplayEmployeeDetails();
        }
    }
}
