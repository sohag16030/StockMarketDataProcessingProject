using StockMarket.Framework.EntityFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.Files
{
    public interface IStockMarketService
    {
        (IList<Stock> records, int total, int totalDisplay) GetStockMarkets(
                                                                     int pageIndex,
                                                                     int pageSize,
                                                                     string searchText,
                                                                     string sortText);
        void Dispose();
        void AddNewStockMarket(Stock stock);
        void DeleteRecord(int id);
        Stock GetRecordById(int id);
        void EditRecord(Stock uprecord);
    }
}
