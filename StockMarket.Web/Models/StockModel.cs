using StockMarket.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Web.Models
{
    public class StockModel
    {
        public List<Stock> getTableData()
        {
            var obj = new DeserializeJsonFileModel();
            var tableData = obj.DeserializeJson();
            return tableData;
        }
    }
}
