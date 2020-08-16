using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DotNetCoreWebApp.Models
{
    public class StockJSONModel
    {
       
        public string Date { get; set; }

        
        public string Trade_Code { get; set; }

       
        public string High { get; set; }

        
        public string Low { get; set; }

        
        public string Open { get; set; }

        
        public string Close { get; set; }

        public string Volume { get; set; }

        //public override string ToString() => JsonSerializer.Serialize<StockJSONModel>(this);
    }
}
