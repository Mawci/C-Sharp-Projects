//===========================================================================================================
//  Nick Rau | 9/13/2024 | Assignment: Lambda Submission
//
//
//===========================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace LambdaSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { firstName = "Joe", lastName = "Smith", Id = 1});
            employees.Add(new Employee() { firstName = "Jason", lastName = "Jones", Id = 2 });
            employees.Add(new Employee() { firstName = "John", lastName = "Jones", Id = 3 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Jackson", Id = 4 });
            employees.Add(new Employee() { firstName = "Nick", lastName = "Rau", Id = 5 });
            employees.Add(new Employee() { firstName = "Tyler", lastName = "Tyson", Id = 6 });
            employees.Add(new Employee() { firstName = "Annita", lastName = "Book", Id = 7 });
            employees.Add(new Employee() { firstName = "Marsha", lastName = "Mellow", Id = 8 });
            employees.Add(new Employee() { firstName = "A.", lastName = "Mused", Id = 9 });
            employees.Add(new Employee() { firstName = "Chris P.", lastName = "Bacon", Id = 10 });

            List<Employee> firstNameJoe = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if(employee.firstName == "Joe")
                {
                    firstNameJoe.Add(employee);
                }
            }

            //**** The above statement with Lambda ****
            List<Employee> firstNameJoeInLambda = new List<Employee>();
            firstNameJoeInLambda = employees.Where(x => x.firstName == "Joe").ToList();
            Console.WriteLine("List of employees with the name Joe:");
            foreach(Employee employee in firstNameJoeInLambda)
            {
                Console.WriteLine($@"{employee.firstName} {employee.lastName} ID: {employee.Id}");
            }
            
            //**** All Employees with ID greater than 5 ****
            List<Employee> greaterThanFive = new List<Employee>();
            greaterThanFive = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("List of employees with ID greater than 5:");
            foreach (Employee employee in greaterThanFive)
            {
                Console.WriteLine($@"{employee.firstName} {employee.lastName} ID: {employee.Id}");
            }
            Console.ReadLine();

        }
    }
}
