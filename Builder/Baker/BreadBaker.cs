using Builder.Bread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Baker
{
    public class BreadBaker
    {
        public Bread.Bread Bake(BreadBuilder.BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
            return breadBuilder.Bread;
        }
    }
}
