using Inheritance.Animal;
using Inheritance.Employee;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ANIMAL
            Dog dog = new Dog();
            dog.Name = "Buddy";
            Animal.Eat();   // Output: Eating...
            dog.Bark();  // Output: Woof!

            Cat cat = new Cat();
            cat.Name = "Kitty";
            Animal.Eat();   // Output: Eating...
            cat.Meow();  // Output: Nyaa!


            //EMPLOYEE
            Manager manager = new Manager
            {
                FirstName = "John",
                LastName = "Doe",
                EmployeeId = "M001",
                Department = "Sales"
            };

            Developer developer = new Developer
            {
                FirstName = "Jane",
                LastName = "Smith",
                EmployeeId = "D001",
                ProgrammingLanguage = "C#"
            };

            manager.PrintDetails();
            Console.WriteLine();

            developer.PrintDetails();
            Console.WriteLine();

            //TUTOR - Multilevel

            CSharpTutor cSharpTutor = new CSharpTutor();
            Console.WriteLine($"Can teach? {cSharpTutor.CanTeach}");
            Console.WriteLine($"Has degree? {cSharpTutor.HasDegree}");
            Console.WriteLine($"Knows CSharp? {cSharpTutor.KnowsCSharp}");

            CSTutor CSTutor = new CSTutor();
            Console.WriteLine($"Can teach? {CSTutor.CanTeach}");
            Console.WriteLine($"Has degree? {CSTutor.HasDegree}");
            Console.WriteLine($"Knows CSharp? {CSTutor.KnowsCSharp}");
        }
    }
}