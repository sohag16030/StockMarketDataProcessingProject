using Newtonsoft.Json;
using StockMarket.Web.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Web.Models
{
    public class DeserializeJsonFileModel
    {
        public List<Stock> DeserializeJson()
        {
            List<Stock> stocks = new List<Stock>();

            using (StreamReader r = new StreamReader(@"H:\MagPie\StockMarket.Web\StockMarket.Web\wwwroot\lib\StockMatketJsonFile\stock_market_data.json"))
            {
                string json = r.ReadToEnd();
                stocks = JsonConvert.DeserializeObject<List<Stock>>(json);

            }
            return (stocks);
        }

    }
}
