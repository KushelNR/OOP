using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsClasses
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

       /* public void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }*/
    }
}
