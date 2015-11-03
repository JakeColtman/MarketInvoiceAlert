using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    interface IEventStream
    {
        bool add_handler(IEventHandler handler);
        bool push_new_updates(); 
    }
}
