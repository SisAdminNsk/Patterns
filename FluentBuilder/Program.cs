using FluentBuilder.Burger;

namespace FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurgerBuilder burgerBuilder = new WhopperBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            var whopper = burgerDirector.GetWhopper();
            var doubleCheeseWhopper = burgerDirector.GetDoubleCheeseWhopper();

            Console.WriteLine(whopper);
            Console.WriteLine(doubleCheeseWhopper);
        }
    }
}
