using FluentBuilder.Burger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public interface IBurgerBuilder
    {
        public IBurgerBuilder AddCutlet();
        public IBurgerBuilder AddCheese();

        public IBurgerBuilder AddBun();
        public IBurgerBuilder AddSalat();
        public Burger.Burger CreateBurger();
    }
}
