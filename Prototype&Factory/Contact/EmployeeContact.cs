using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Factory.Contact
{
    [Serializable]
    public class EmployeeContact
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
