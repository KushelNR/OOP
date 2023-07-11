using Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_02
{
    public class ShoppingCart : FruitBasket //Derived class, different assembly
    {
        /*public ShoppingCart()
        {
            Apples = 1; //private
            Mangoes = 1; //private protected
            Oranges = 1; //internal
            Pineapples = 1; //protected
            Bananas = 1; //protected internal
            Watermelons = 1; //public
        }*/

        public ShoppingCart()
        {

        }

        public void ShoppingCartCount()
        {
            FruitCount();
        }
    }
}
