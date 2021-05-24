using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell
{
    public class ImplmentInvest
    {
        datastore stockfile = new datastore();
        //new class called datastore
        //datastore from another program
        //has the following fields
        //  list of prices
        //  name of stock
        //  fees 
        static bool TimeToBuy(datastore _stockfile)
        {
            List<decimal> price = _stockfile.price;
            decimal fees = _stockfile.fees;
            // replace p with (p + fees)
            //old code. I added the code above to just add the fees to it
            int len_4 = price.Count() / 4;
            int len_50 = (price.Count() / 2) - 1;
            int len_75 = (3 * price.Count() / 4) - 1;
            //myList.GetRange(50, 10)
            // Retrieves 10 items starting with index #50
            //remove max and min and use database idea!
            List<decimal> price1 = FindTheMax(price.GetRange(0, len_4));
            decimal M = price.GetRange(0, len_4).Max();
            List<decimal> price2 = FindTheMax(price.GetRange((len_4), len_4));
            decimal W = price2.Max();
            bool v = M > (W + fees);
            if (v)
            {
                return !v;
            }
            List<decimal> price3 = FindTheMin(price.GetRange((len_50), len_4));
            decimal L = price3.Min();
            List<decimal> price4 = FindTheMin(price.GetRange(len_75, len_4));
            decimal R = price4.Min();
            v = ((R > M && R > L) | L != 0);
            return v;
            //you get to this point then tell the user to BUY
            //when they confirm the price they bought it save it
        }

        static bool TimeToSell(datastore _stockfile)
        {
            decimal price = _stockfile.currentprice;
            List<decimal> range = _stockfile.price;
            int len = range.Count;
            int len_4 = len / 4;
            int len_50 = len / 2;
            int len_75 = 3 * len / 4;
            List<decimal> price_1 = FindTheMax(range.GetRange(0, len_4));
            decimal M = range.Max();
            //Figure this 1.05 out. I know 105% but still see if it good in unit testing
            bool v = ((1.05m * price) <= M | M == 0);
            if (v)
            {
                return !v;
            }
            List<decimal> price_2 = FindTheMin(range.GetRange((len_4 - 1), len_4));
            decimal L = price_2.Min();
            v = (price <= L | L == 0);
            if (v)
            {
                return !v;
            }
            List<decimal> price_3 = FindTheMax(range.GetRange((len_50 - 1), len_4));
            decimal W = price_1.Max();
            v = (M <= W);
            if (v)
            {
                return !v;
            }
            List<decimal> price_4 = FindTheMin(range.GetRange((len_75 - 1), len_4));
            //double S = myLow.Min(); look into this one again
            decimal R = price_4.Min();
            //Fix the V formula to make a 10% loss with 15% margin of error
            v = (R < (0.75m * price) && R != 0);
            return v;
        }
        //min method with the added feature to check if the min is at the end points
        static List<decimal> FindTheMin(List<decimal> listofStock)
        {
            /*High
             * Low
             * Date
             * find a way to get only one of three at a time
            */
            decimal min = listofStock.Min();
            int m_i = listofStock.ToList().IndexOf(listofStock.Min());
            int length = listofStock.Count();
            if (m_i != (length - 1) && m_i != 0)
            {
                return listofStock;
            }
            else
            {
                List<decimal> bad = new List<decimal> { 0 };
                return bad;
            }


            /*if (m_i == length)
            {
                min = StocksQuery();
            }
            else if (m_i == 0)
            {
                min = StocksQuery();
                //make half chopper
                return
            }
            else
            {
                return min;
            }
            */
        }
        //max method with the added feature to check if the max is at the end points
        static List<decimal> FindTheMax(List<decimal> listofStock)
        {
            decimal max = listofStock.Max();
            int m_i = listofStock.ToList().IndexOf(max);
            int length = listofStock.Count();
            if (m_i != (length - 1) && m_i != 0)
            {
                return listofStock;
            }
            else
            {
                List<decimal> bad = new List<decimal> { 0 };
                return bad;
            }
            /*
            if (m_i == 0)
            {
                max = StocksQuery();
            }
            else if (m_i == length)
            {
                //max = Halfchopper("High", max, length);
                return max;
            }
            else
            {
                return max;
            }
            */

        }

    }
}
