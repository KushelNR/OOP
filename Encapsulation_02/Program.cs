using Encapsulation;

namespace Encapsulation_02
{
    public class Program // Non-derived class, different assembly
    {
        static void Main(string[] args)
        {
            //FRUITS
            FruitBasket fruitBasket = new FruitBasket();
            /*fruitBasket.Apples = 1; //private
            fruitBasket.Mangoes = 1; //private protected
            fruitBasket.Oranges = 1; //internal
            fruitBasket.Pineapples = 1; //protected
            fruitBasket.Bananas = 1; //protected internal
            fruitBasket.Watermelons = 1; //public*/

            fruitBasket.FruitCount();
        }
    }
}