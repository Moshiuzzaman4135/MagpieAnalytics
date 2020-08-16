using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using DotNetCoreWebApp.Models;
using System.IO;

namespace DotNetCoreWebApp.Services
{
    public class JsonFileStockMarket
    {
        
        public JsonFileStockMarket(IHostingEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IHostingEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "stock_market_data.json"); }
        }

        public IEnumerable<StockJSONModel> GetAll()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<StockJSONModel[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        
    }
}
