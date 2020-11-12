using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Web.Entities
{
    public class Stock
    {
        public DateTime date { get; set; }
        public string trade_code { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public string volume { get; set; }
    }
}
