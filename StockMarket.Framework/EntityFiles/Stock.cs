using StockMarket.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.EntityFiles
{
    public class Stock : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string trade_code { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public string volume { get; set; }

    }
}
