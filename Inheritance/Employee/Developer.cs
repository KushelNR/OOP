using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Employee.Employee
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }
}
