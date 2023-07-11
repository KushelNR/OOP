using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
