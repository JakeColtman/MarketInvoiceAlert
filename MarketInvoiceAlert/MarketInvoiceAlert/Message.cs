using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    abstract class Message
    {
        //Basic message class - extend this to create different message types
    }

    class NewPaymentMessage: Message
    {

    }

    class NewPaymentWithAmountMessage: Message
    {
        public int amount { get; set; }
    }

}
