using Builder.Bread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBakers
{
    public class WheatBreadBuilder : BreadBuilder.BreadBuilder
    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives { Name = "консервант E245"};
        }
    }
}
