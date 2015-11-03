using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    class MockEventHandler : IEventHandler
    {
        public bool can_handle(Message message)
        {
            return true;
        }

        public bool handle(Message message)
        {
            Console.WriteLine("Sent message");
            return true;
        }
    }
}
