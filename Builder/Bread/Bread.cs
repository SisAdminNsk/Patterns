using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Bread
{
    public class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt {  get; set; }
        public Additives Additives {  get; set; }
    }
}
