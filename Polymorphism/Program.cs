using Polymorphism.Animal;
using Polymorphism.Shape;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ANIMALS
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();  // Output: Woof!
            cat.MakeSound();  // Output: Meow!

            List<Animal> animals = new List<Animal>();
            Dog dog1 = new Dog();
            Cat cat1 = new Cat();
            animals.Add(dog1);
            animals.Add(cat1);

            cat.EyeColour


            //SHAPES
            Circle circle = new Circle(10);
            Triangle triangle = new Triangle(2, 4);
            Rectangle rectangle = new Rectangle(6, 3);
            Shape[] shapes = new Shape[] {circle, triangle, rectangle};

            ShapeCalculator shapeCalculator = new ShapeCalculator();
            Console.WriteLine(shapeCalculator.CalculateTotalArea(shapes));
        }
    }
}