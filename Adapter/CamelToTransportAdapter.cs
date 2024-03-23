using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CamelToTransportAdapter : ITransport
    {
        public void Move()// calling the method to force camel be like a transport
        {
            Console.WriteLine("Camel moving...");
        }

        private Camel camel;
        public CamelToTransportAdapter(Camel camel)
        {
            this.camel = camel;
        }
    }
}
