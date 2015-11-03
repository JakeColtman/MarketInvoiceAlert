using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketInvoiceAlert;

namespace MarketInvoiceAlert.Telegram
{
    class TelegramEventHandler : IEventHandler
    {
        ITelegramAPI _api;

        public TelegramEventHandler(ITelegramAPI api)
        {
            _api = api;
        }

        public bool can_handle(Message message)
        {
            return true;
        }

        public bool handle(Message message)
        {
            NewPaymentMessage paymentMsg = message as NewPaymentMessage;
            _api.send_message("Payment message recieved");
            return true;
        }
    }
}
