using System.Collections.Generic;

namespace ReflectionAvalonia.Models
{
    public abstract class PresentationComponent
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public PresentationComponent(string name, object value)
        {
            Name = name;
            Value = value;
        }

        protected PresentationComponent(string name)
        {
            Name = name;
        }

        public abstract void Add(PresentationComponent component);
        public abstract void Remove(PresentationComponent component);
    }
}
