using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BreadBuilder
{
    public abstract class BreadBuilder
    {
        public Bread.Bread Bread { get; private set; }

        public void CreateBread()
        {
            Bread = new Bread.Bread();
        }

        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
