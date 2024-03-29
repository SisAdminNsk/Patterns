using Builder.Bread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBakers
{
    public class RyeBreadBuilder : BreadBuilder.BreadBuilder
    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Bread.Flour { Sort = "Пшеничная мука высший сорт" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Bread.Salt();
        }

        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives { Name = "разрыхлитель E105" };
        }
    }
}
