namespace ObjectsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.GoToLunch();
            employee.DoWork();

            Console.WriteLine(AscenticValues.NumberOfValues);
            AscenticValues.ListValues();
        }
    }
}