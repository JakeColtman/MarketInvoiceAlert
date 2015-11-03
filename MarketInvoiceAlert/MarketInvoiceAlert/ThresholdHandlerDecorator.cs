using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    class ThresholdHandlerDecorator : IEventHandler
    {
        IEventHandler _decoratedHandler;
        int _threshold;

        public ThresholdHandlerDecorator(IEventHandler decoratedHandler, int threshold)
        {
            //Adds thresholding so only payments over a certain size are passed on
            _decoratedHandler = decoratedHandler;
            _threshold = threshold;
        }

        public bool can_handle(Message message)
        {
            if (message is NewPaymentWithAmountMessage && ((message as NewPaymentWithAmountMessage).amount < _threshold)) return false;
            return _decoratedHandler.can_handle(message);
        }

        public bool handle(Message message)
        {
            return _decoratedHandler.handle(message);
        }
    }
}
