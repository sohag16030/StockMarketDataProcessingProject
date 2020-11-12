using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockMarket.Web.Entities;
using StockMarket.Web.Models;

namespace StockMarket.Web.Controllers
{
    public class StockMarketController : Controller
    {
        private readonly ILogger<StockMarketController> _logger;

        public StockMarketController(ILogger<StockMarketController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {

            var model = new StockModel();
            model.getTableData();
            return View(model);
        }
    }

   
}
