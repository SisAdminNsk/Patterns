using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class BurgerDirector
    {
        private IBurgerBuilder builder;
        public BurgerDirector(IBurgerBuilder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(IBurgerBuilder burgerBuilder)
        {
            this.builder = burgerBuilder;
        }

        public Burger.Burger GetWhopper()
        {
            builder.AddBun()
                .AddSalat()
                .AddCutlet()
                .AddCheese()
                .AddBun();

            return builder.CreateBurger();
        }

        public Burger.Burger GetDoubleCheeseWhopper()
        {
            builder.AddBun()
                .AddSalat()
                .AddCutlet()
                .AddCheese()
                .AddCheese()
                .AddBun();

            return builder.CreateBurger();
        }
    }
}
