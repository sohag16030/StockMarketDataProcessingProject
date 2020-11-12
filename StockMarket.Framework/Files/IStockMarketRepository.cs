using StockMarket.Data;
using StockMarket.Framework.ContextModule;
using StockMarket.Framework.EntityFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.Files
{
    public interface IStockMarketRepository : IRepository<Stock, int, FrameworkContext>
    {
    }
}
