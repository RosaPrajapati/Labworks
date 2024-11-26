using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaLabworks
{
    internal class lab2_q1
    {
        class Employee
        {

            public string Name { get; set; }
            public string Email { get; set; }
            public decimal Salary { get; set; }


            public Employee(string name, string email, decimal salary)
            {
                Name = name;
                Email = email;
                Salary = salary;
            }


            public void DisplayEmployeeInfo()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Salary: {Salary:C}");
            }


            /*static void Main()
            {
                // Create Employee object
                Employee emp = new Employee("Rosa Prajapati", "rosa@example.com", 60000);

                // Display employee details
                emp.DisplayEmployeeInfo();
                Console.ReadKey();
            }*/
        }
    }
}