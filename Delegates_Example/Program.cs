using System;
using System.Collections.Generic;

namespace Delegates_Example
{
    internal static class Program
    {
        public static void Main()
        {
            var employeesList = new List<Employee>
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Harshal Raverkar",
                    Address = "Bangalore",
                    experience = 2,
                    Salary = 42000
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Raverkar ji",
                    Address = "Mumbai",
                    experience = 6,
                    Salary = 56000
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Rakesh Raverkar",
                    Address = "indore",
                    experience = 8,
                    Salary = 41000
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Test Raverkar",
                    Address = "Udupi",
                    experience = 5,
                    Salary = 40000
                }
            };

            var emp = new Employee();
            emp.Pramoteempolyee(employeesList);
        }
    }


    public class Employee
    {
        public int Id { get; set;  }
        public string Name { private get; set; }
        public int Salary { get; set; }
        public int experience { private get; set; }
        public string Address { get; set; }


        public  void Pramoteempolyee(IEnumerable<Employee> employeeList)
        {
            foreach (var employee in employeeList)
            {
                if (employee.experience >= 5)
                {
                   Console.WriteLine(employee.Name +" is Promoted");
                }
            }
        }
        
    }
}