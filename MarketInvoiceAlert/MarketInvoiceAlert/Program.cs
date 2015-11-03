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

            Telegram.ITelegramAPI api = new Telegram.TelegramAPI(HiddenAuth.get_auth(), HiddenAuth.get_chatid());

            IEventHandler teleGramHandler = new Telegram.TelegramEventHandler(api);
            IEventStream dummyStream = new MockAPIStream(new List<IEventHandler>() { teleGramHandler });
            IMonitor monitor = new Monitor(dummyStream);

            monitor.set_off();

        }
    }
}
