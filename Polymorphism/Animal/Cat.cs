using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Animal
{
    public class Cat : Animal
    {
        public string EyeColour;
        public Cat()
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(EyeColour);
        }
    }
}
