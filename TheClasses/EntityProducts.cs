using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public abstract class EntityProducts
    {
       
        public int TotalOfItems { get { return _totalofitems; } set { _totalofitems = value; } }
        public int TotalOfPrice { get { return _totalofprice; } set { _totalofprice = value; } }
        //Number
        public string[] _num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        //Total of all
        public static int _totalofitems, _totalofprice;

        public abstract void CountPriceAndItems(int amount, int option);

        public abstract string UpdatePrice(string valpriceCart);

        public abstract string UpdateItems(string valitemsCart);

        public abstract bool NumberCheck(string value);       

        //public abstract bool NotNumberContain(string value);
    }
}
