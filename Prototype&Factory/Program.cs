namespace Prototype_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeFactory employeeFactory = new EmployeeFactory();
            var mainOfficeEmployee =  employeeFactory.NewMainOfficeEmployeeContact("John", 100);
            var fillialOfficeEmployee = employeeFactory.NewFillialOfficeEmployeeContact("Max", 200);

            Console.WriteLine(mainOfficeEmployee);
            Console.WriteLine(fillialOfficeEmployee);
        }
    }
}
