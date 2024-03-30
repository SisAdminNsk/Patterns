using FluentBuilder.Burger;
using System.Text;

namespace FluentBuilder
{
    public class WhopperBuilder : IBurgerBuilder
    {
        private Burger.Burger burger = new Burger.Burger();
        IBurgerBuilder IBurgerBuilder.AddBun()
        {
            burger.Bun.Add(new Bun() { Name = "sesame bun" });
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddCheese()
        {
            burger.Cheese.Add(new Cheese() { Name = "gauda cheese" });
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddCutlet()
        {
            burger.Cutlet.Add(new Cutlet() {Name = "premium beef cutlet" });
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddSalat()
        {
            burger.Salat.Add(new Salat() { Name= "fresh lettuce leaves" });
            return this;
        }

        Burger.Burger IBurgerBuilder.CreateBurger()
        {
            Burger.Burger readyBurger = burger;
            burger = new Burger.Burger();
            return readyBurger;
        }
    }
}
