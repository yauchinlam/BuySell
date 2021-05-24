using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell
{
    //This will implement the invest on each item and add to Azure
    public class ImplementInvest
    {
        //call an instance of the class
        //it will be via a message reply and receive 
        //put in queque
        
        //this instance will receive the data from the gRPC
        public datastore stockdata = new datastore();
        //will NOT be called StockDict...it will be called StockData.stockname
        private Dictionary<DateTime, byte> StockDict;
        public void BuySellStorage(datastore Stockdata)
        {
            bool b = AlgoInvest.TimeToBuy(Stockdata);
            bool s = AlgoInvest.TimeToSell(Stockdata);
            bool[] options = {b,s};
            byte bOptions = ConvertBoolArrayToByte(options);

            switch (bOptions)
            {
                case 0:
                    break;
                case 1:
                    DateTime stocktimesell = DateTime.Now;
                    AddtoAzure(stocktimesell, bOptions);
                    Console.WriteLine($"Time to sell {stockdata.Stockname} at time {stocktimesell}");
                    break;
                case 2:
                    DateTime stocktimebuy = DateTime.Now;
                    AddtoAzure(stocktimebuy, bOptions);
                    Console.WriteLine($"Time to buy {stockdata.Stockname} at time {stocktimebuy}");
                    break;
                case 3:
                    //put an error handler here
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        private static byte ConvertBoolArrayToByte(bool[] source)
        {
            byte result = 0;
            // This assumes the array never contains more than 8 elements!
            int index = 8 - source.Length;

            // Loop through the array
            foreach (bool b in source)
            {
                // if the element is 'true' set the bit at that position
                if (b)
                    result |= (byte)(1 << (7 - index));

                index++;
            }

            return result;
        }

        private void AddtoAzure(DateTime timeto, byte dosomething)
        {
            //this will become the method that will add to Azure but for now add to a local dict
            StockDict.Add(timeto, dosomething);
        }
    }
}
