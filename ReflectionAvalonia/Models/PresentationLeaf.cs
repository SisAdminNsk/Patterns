using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAvalonia.Models
{
    public class PresentationLeaf : PresentationComponent
    {
        public PresentationLeaf(string name,object value) : base(name,value) { }
        public override void Add(PresentationComponent component)
        {
        }
        public override void Remove(PresentationComponent component)
        {
        }
    }
}
