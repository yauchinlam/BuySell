using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell
{
    //This will implement the invest on each item
    public class ImplementInvest
    {
        //call an instance of the class
        //it will be via a message reply and receive 
        //put in queque
        
        //this instance will receive the data from the gRPC
        public datastore tockdata = new datastore();
        
        public Dictionary<DateTime, bool> BuySellStorage(datastore Stockdata)
        {
            Dictionary<DateTime, bool> stockdict = new Dictionary<DateTime, bool>();
            bool v = AlgoInvest.TimeToBuy(Stockdata);
            if (v) 
                //need to add instance to check if dict already stored
                //create a file reader and deserializer here
            {
                //need to be called stockname
                DateTime stocktime = DateTime.Now;
                stockdict.Add(stocktime, v);
                //Queue<bool> StockName = new Queue<bool>();
                //StockName.Enqueue(v);
                return stockdict;
            }
            else
                return null;
        }
    }
}
