using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Traveler
    {
        private ITransport transport;
        public Traveler(ITransport transport)
        {
            this.transport = transport;
        }

        public void SetTransport(ITransport newTransport)
        {
            transport = newTransport;
        }

        public void Travel()
        {
            transport.Move();
        }
    }
}
