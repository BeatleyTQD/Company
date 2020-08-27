using System;
using System.Collections.Generic;

namespace Classes
{

    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime DateFounded)
        {
            Name = name;
            CreatedOn = DateFounded;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company BeardTech = new Company("BeardTech", DateTime.Now);

            // Create three employees
            Employee Brandon = new Employee();
            Brandon.FirstName = "Brandon";
            Brandon.LastName = "Wheatley";
            Brandon.Title = "King";
            Brandon.StartDate = new DateTime(2000, 1, 18);

            Employee Julie = new Employee();
            Julie.FirstName = "Julie";
            Julie.LastName = "Schmidt";
            Julie.Title = "Jester";
            Julie.StartDate = new DateTime(2008, 8, 28);

            Employee Kevin = new Employee();
            Kevin.FirstName = "Kevin";
            Kevin.LastName = "Schmidt";
            Kevin.Title = "Second King";
            Kevin.StartDate = new DateTime(2019, 4, 6);

            // Assign the employees to the company
            BeardTech.Employees.Add(Brandon);
            BeardTech.Employees.Add(Julie);
            BeardTech.Employees.Add(Kevin);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            BeardTech.ListEmployees();
        }
    }
}