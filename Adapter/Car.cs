using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Car : ITransport
    {
        public void Move()
        {
            Console.WriteLine("Car Moving...");
        }
    }
}
