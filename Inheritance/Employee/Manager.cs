using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Employee
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }
}
