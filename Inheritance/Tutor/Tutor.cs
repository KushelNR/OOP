using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutor
{
    public abstract class Tutor
    {
        public bool CanTeach { get; set; }

        public abstract void Teach();
    }
}
