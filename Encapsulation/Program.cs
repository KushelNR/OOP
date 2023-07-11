namespace Encapsulation
{
    public class Program //Non-derived class, same assembly
    {
        static void Main(string[] args)
        {
            //CAR
            Car myCar = new Car("Honda");
            Car myCar2 = new Car(1998);
            /*myCar.Model = "Honda";
            myCar.Year = 2022;*/

            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");

            myCar.StartEngine();

            //FRUITS
            /*ruitBasket fruitBasket = new FruitBasket();
            fruitBasket.Apples = 1; //private
            fruitBasket.Mangoes = 1; //private protected
            fruitBasket.Oranges = 1; //internal
            fruitBasket.Pineapples = 1; //protected
            fruitBasket.Bananas = 1; //protected internal
            fruitBasket.Watermelons = 1; //public*/

            //fruitBasket.FruitCount();
        }
    }
}