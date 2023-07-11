using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsClasses
{
    public static class AscenticValues
    {
        public static int NumberOfValues = 5;
        public static List<string> Values = new() { "Geeky", "Gritty", "Diverse", "Courage", "Family" };

        public static void ListValues()
        {
            foreach (string value in Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
