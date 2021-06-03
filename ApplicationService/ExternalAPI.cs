using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class ExternalAPI
    {
        string coinURL = "https://api.coingecko.com/api/v3/";

        public List<string> CoinList()
        {
            coinURL += "coins/list";

            var client = new WebClient();
            var body = "";

            body = client.DownloadString(coinURL);

            List<string> coinData = JsonConvert.DeserializeObject<List<string>>(body);

            return coinData;
        }
    }
}
