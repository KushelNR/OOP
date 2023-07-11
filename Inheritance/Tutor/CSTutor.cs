using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tutor.Tutor
{
    public class CSTutor : Tutor, ICSharpStudent
    {
        public bool HasDegree { get; set; }
        public bool KnowsCSharp { get; set; }

        public override void Teach()
        {
            Console.WriteLine("I can Teach CS!");
        }
    }
}
