using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class PicnicBasket : FruitBasket //Derived class, same assembly
    {
        /*public PicnicBasket() {
            Apples = 1; //private
            Mangoes = 1; //private protected
            Oranges = 1; //internal
            Pineapples = 1; //protected
            Bananas = 1; //protected internal
            Watermelons = 1; //public
        }*/

        public PicnicBasket()
        {

        }

        public void PicnicBasketCount()
        {
            FruitCount();
        }
    }
}
