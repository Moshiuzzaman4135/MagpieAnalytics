using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApp.Models
{
    public class StocksJSON
    {
        public IList<StockJSONModel> Stocks {get;set;}
    }
}
