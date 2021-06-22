using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class StockService: Stock.Stockbase
    {
        private readonly ILogger<StockService> _logger;

        public StockService(ILogger<StockService> logger)
        {
            _logger = logger;
        }

        public override Task<StockModel> GetStockInfo(StockLookupModel request, ServerCallContext )
    }
}
