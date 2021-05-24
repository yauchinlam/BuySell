using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell
{
    public class datastore
    {
        //data needs to be given to
        //serialization and deserialization of data happens
        public string stockname { get; set; }
        public List<decimal> price { get; set; }

        //change the get;set of fees to acknowledge the fee being null even though unlikely
        public decimal fees { get; set; }

        public decimal currentprice { get; set; }
    }
}
