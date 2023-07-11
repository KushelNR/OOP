using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animal
{
    public sealed class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
