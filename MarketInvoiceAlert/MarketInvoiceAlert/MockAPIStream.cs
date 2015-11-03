using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    class MockAPIStream : IEventStream
    {

        IList<IEventHandler> _handlers;

        public MockAPIStream() : this(new List<IEventHandler>())
        {
        }

        public MockAPIStream(List<IEventHandler> handlers)
        {
            _handlers = handlers;
        }

        public bool add_handler(IEventHandler handler)
        {
            _handlers.Add(handler);
            return true;
        }

        public bool push_new_updates()
        {
            Message message = new NewPaymentMessage();
            return _handlers
                        .Where(x => x.can_handle(message))
                        .Select(x => x.handle(message))
                        .All(x => x);
        }
    }
}
