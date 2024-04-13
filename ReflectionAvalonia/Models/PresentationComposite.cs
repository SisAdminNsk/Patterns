using System.Collections.Generic;
using System.Linq;

namespace ReflectionAvalonia.Models
{
    public class PresentationComposite : PresentationComponent
    {
        private List<PresentationComponent> children = new List<PresentationComponent>();
        public List<PresentationComponent> Childern
        {
            get => children;
            private set => children = value;
        }

        public PresentationComposite(string name, object value) : base(name, value) { }

        public override void Add(PresentationComponent component)
        {
            Childern.Add(component);
        }
        public override void Remove(PresentationComponent component) 
        {
            Childern.Remove(component);
        }
    }
}
