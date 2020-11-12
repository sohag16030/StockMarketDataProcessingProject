using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Framework.ResponseFiles
{
    public class DuplicationException : Exception
    {
        public string DuplicateItemName { get; private set; }
        public DuplicationException(string message, string itemName)
            : base(message)
        {
            DuplicateItemName = itemName;
        }
    }
}
