using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class FruitBasket
    {
        private int Apples { get; set; }
        private protected int Mangoes { get; set; }
        internal int Oranges { get; set; }
        protected int Pineapples { get; set; }
        protected internal int Bananas { get; set; }
        public int Watermelons { get; set; }

        public void FruitCount()
        {
            Console.WriteLine($"There are {Apples + Mangoes + Oranges + Pineapples + Bananas + Watermelons} fruits!");
        }
    }
}
