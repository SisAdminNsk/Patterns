using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Factory.Contact
{
    [Serializable]
    public class Address
    {
        public string Street {  get; set; }
        public int Suite { get; set; }

        public string City { get; set; }

        public override string ToString()
        {
            return $"Street: {Street}, City: {City}, Suite: {Suite}";
        }
    }
}
