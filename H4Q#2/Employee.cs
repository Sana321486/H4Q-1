using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4Q_2
{
    internal class Employee
    {
        public int employeeID;
        public string name;
        public string department;
        public double salary;

        public Employee()
        {
            
            employeeID = employeeID;
            name = name;
            department = department;
            salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("\tEmployee details are as follow:");        
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Department: {department}");
            Console.WriteLine($"Employee Salary: {salary}");
        }
        public void IncreaseSalary(double amount)
        {
            salary = amount + salary;
            Console.WriteLine($"New Salary: {salary}");
        }
    }
}
