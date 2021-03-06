using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    //this is the model that will receive the message reply of the gRPC
    public class DataStoreModel
    {
        string _stockname;
        List<decimal> _price;
        decimal _fees;
        decimal _currentprice;
        //data needs to be given to
        //serialization and deserialization of data happens
        public string Stockname { get => _stockname; set => _stockname = value; } 
        public List<decimal> Price { get => _price; set => _price = value;  }

        //change the get;set of fees to acknowledge the fee being null even though unlikely
        public decimal Fees { get => _fees; set => _fees = value; }

        public decimal Currentprice { get => _currentprice; set => _currentprice=value; }
    }
}
