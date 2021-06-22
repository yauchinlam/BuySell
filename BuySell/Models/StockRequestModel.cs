using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class StockRequestModel
    {
        public string StockChoice;

        public DataStoreModel outputStock;
        public StockRequestModel()
        {
            
        }
        public void StockWebsiteRequest()
        {
            //either here you make the gRPC request or somein separate CS files
            
        }
    }
}
