using Builder.ConcreteBakers;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baker.BreadBaker breadBaker = new Baker.BreadBaker();
            BreadBuilder.BreadBuilder breadBuilder = new RyeBreadBuilder();
            Bread.Bread ryeBread = breadBaker.Bake(breadBuilder);

            Console.WriteLine(ryeBread.Flour.Sort + " " + ryeBread.Additives.Name);

            breadBuilder = new WheatBreadBuilder();
            Bread.Bread whiteBread = breadBaker.Bake(breadBuilder);

            Console.WriteLine(whiteBread.Flour.Sort + " " + whiteBread.Additives.Name);
        }
    }
}
