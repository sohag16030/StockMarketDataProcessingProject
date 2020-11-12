using StockMarket.Data;
using StockMarket.Framework.ContextModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.Files
{
    public class StockMarketUnitOfWork : UnitOfWork, IStockMarketUnitOfWork
    {
        public IStockMarketRepository StockMarketRepository { get; set; }
        public StockMarketUnitOfWork(FrameworkContext context, IStockMarketRepository stockMarketRepository) : base(context)
        {
            StockMarketRepository = stockMarketRepository;
        }
    }
}
