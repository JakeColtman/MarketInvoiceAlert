using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    class Program
    {
        static void Main(string[] args)
        {

            IEventHandler dummyHandler = new MockEventHandler();
            IEventStream dummyStream = new MockAPIStream(new List<IEventHandler>() { dummyHandler });
            IMonitor monitor = new Monitor(dummyStream);

            monitor.set_off();

        }
    }
}
