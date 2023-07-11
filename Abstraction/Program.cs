namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            double circleArea = circle.CalculateArea();
            double rectangleArea = rectangle.CalculateArea();

            Console.WriteLine($"Circle area: {circleArea}");
            Console.WriteLine($"Rectangle area: {rectangleArea}");

            circle.Display();
            rectangle.Display();

            Console.WriteLine(string.Concat("Hello ", "World"));
        }
    }
}