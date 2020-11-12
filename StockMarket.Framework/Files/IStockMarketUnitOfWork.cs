using StockMarket.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.Files
{
    public interface IStockMarketUnitOfWork : IUnitOfWork
    {
        IStockMarketRepository StockMarketRepository { get; set; }
    }
}
