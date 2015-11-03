using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace MarketInvoiceAlert.Telegram
{
    class TelegramAPI : ITelegramAPI
    {

        string _token;
        int _chatId;

        public TelegramAPI(string token, int chatId)
        {
            _chatId = chatId;
            _token = token;
        }

        public bool send_message(string contents)
        {
            var client = new HttpClient();
            string url = String.Format(@"https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}", _token, _chatId.ToString(), "PaymentRecieved");
            Console.WriteLine(url);
            client.PostAsync(url, new StringContent("")).Wait();
            return true;
        }
    }
}
