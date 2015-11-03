using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInvoiceAlert
{
    class Monitor : IMonitor
    {
        IEventStream _stream;
        int _frequency;
        
        public Monitor(IEventStream stream)
        {
            _stream = stream;
            _frequency = 2000;
        } 
       

        public void set_off()
        {
            Console.WriteLine("Starting monitoring \n Ctr-C to stop!");
            while (true)
            {
                System.Threading.Thread.Sleep(_frequency);
                Console.WriteLine("Checking for new messages");
                _stream.push_new_updates();               

            }
        }
    }
}
