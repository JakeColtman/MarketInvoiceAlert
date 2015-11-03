using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert.Telegram
{
    interface ITelegramAPI
    {
        bool send_message(string contents);
    }
}
