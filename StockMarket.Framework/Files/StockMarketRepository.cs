using StockMarket.Data;
using StockMarket.Framework.ContextModule;
using StockMarket.Framework.EntityFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.Files
{
    public class StockMarketRepository : Repository<Stock, int, FrameworkContext>, IStockMarketRepository
    {
        public StockMarketRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
