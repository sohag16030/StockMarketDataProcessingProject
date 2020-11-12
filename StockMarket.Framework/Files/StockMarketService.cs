using StockMarket.Framework.EntityFiles;
using StockMarket.Framework.ResponseFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket.Framework.Files
{
    public class StockMarketService : IStockMarketService
    {
        private IStockMarketUnitOfWork _stockMarketUnitOfWork;
        public StockMarketService(IStockMarketUnitOfWork stockMarketUnitOfWork)
        {
            _stockMarketUnitOfWork = stockMarketUnitOfWork;
        }

        public void AddNewStockMarket(Stock stock)
        {

            _stockMarketUnitOfWork.StockMarketRepository.Add(stock);
            _stockMarketUnitOfWork.Save();
        }

        public void DeleteRecord(int id)
        {
            _stockMarketUnitOfWork.StockMarketRepository.Remove(id);
            _stockMarketUnitOfWork.Save();
        }

        public void Dispose()
        {
            _stockMarketUnitOfWork?.Dispose();
        }

        public void EditRecord(Stock uprecord)
        {
            var count = _stockMarketUnitOfWork.StockMarketRepository.GetCount(x => x.trade_code == uprecord.trade_code && x.Id != uprecord.Id);
            if (count > 0)
                throw new DuplicationException("Trade Code Exists", nameof(uprecord.trade_code));
            var exitRecord = _stockMarketUnitOfWork.StockMarketRepository.GetById(uprecord.Id);
            exitRecord.date = uprecord.date;
            exitRecord.trade_code = uprecord.trade_code;
            exitRecord.high = uprecord.high;
            exitRecord.low = uprecord.low;
            exitRecord.open = uprecord.open;
            exitRecord.close = uprecord.close;
            exitRecord.volume = uprecord.volume;
            _stockMarketUnitOfWork.StockMarketRepository.Edit(exitRecord);
            _stockMarketUnitOfWork.Save();
        }

        public (IList<Stock> records, int total, int totalDisplay) GetStockMarkets(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _stockMarketUnitOfWork.StockMarketRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public Stock GetRecordById(int id)
        {
            return _stockMarketUnitOfWork.StockMarketRepository.GetById(id);
        }
    }
}
