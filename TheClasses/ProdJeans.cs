using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public class ProdJeans : EntityProducts
    {

        #region Field Region

        //Name jeans
        string _jeans1, _jeans2, _jeans3,
               _jeans4, _jeans5;

        //Total jeans
        int _totaljeans1, _totaljeans2, _totaljeans3,
            _totaljeans4, _totaljeans5;

        //Price accessories
        int _pricejeans1, _pricejeans2, _pricejeans3,
            _pricejeans4, _pricejeans5;

        #endregion

       #region Properties Region

        //Used to Name/Rename the Jeans
        public string NameJeans1 { get { return _jeans1; } set { _jeans1 = value; } }
        public string NameJeans2 { get { return _jeans2; } set { _jeans2 = value; } }
        public string NameJeans3 { get { return _jeans3; } set { _jeans3 = value; } }
        public string NameJeans4 { get { return _jeans4; } set { _jeans4 = value; } }
        public string NameJeans5 { get { return _jeans5; } set { _jeans5 = value; } }       

        //Used to Get/Set the price of each Jeans
        public int PriceJeans1 { get { return _pricejeans1; } set { _pricejeans1 = value; } }
        public int PriceJeans2 { get { return _pricejeans2; } set { _pricejeans2 = value; } }
        public int PriceJeans3 { get { return _pricejeans3; } set { _pricejeans3 = value; } }
        public int PriceJeans4 { get { return _pricejeans4; } set { _pricejeans4 = value; } }
        public int PriceJeans5 { get { return _pricejeans5; } set { _pricejeans5 = value; } }

        //Used to Get the number of Jeans 
        public int TotalJeans1 { get { return _totaljeans1; } set { _totaljeans1 = value; } }
        public int TotalJeans2 { get { return _totaljeans2; } set { _totaljeans2 = value; } }
        public int TotalJeans3 { get { return _totaljeans3; } set { _totaljeans3 = value; } }
        public int TotalJeans4 { get { return _totaljeans4; } set { _totaljeans4 = value; } }
        public int TotalJeans5 { get { return _totaljeans5; } set { _totaljeans5 = value; } }
       
        #endregion

        #region Constructor

        public ProdJeans()
        {
          
            _totaljeans1 = 0;
            _totaljeans2 = 0;
            _totaljeans3 = 0;
            _totaljeans4 = 0;
            _totaljeans5 = 0;           
          
        }

        #endregion

        #region Methods

        //Total price & items method (for individual products & total products)
        public override void CountPriceAndItems(int amount, int option)
        {
            switch (option)
            {
                case 1:
                    _totaljeans1 += amount;
                    _totalofprice += _pricejeans1 * amount;
                    _totalofitems += _totaljeans1;
                    break;
                case 2:
                    _totaljeans2 += amount;
                    _totalofprice += _pricejeans2 * amount;
                    _totalofitems += _totaljeans2;
                    break;
                case 3:
                    _totaljeans3 += amount;
                    _totalofprice += _pricejeans3 * amount;
                    _totalofitems += _totaljeans3;
                    break;
                case 4:
                    _totaljeans4 += amount;
                    _totalofprice += _pricejeans4 * amount;
                    _totalofitems += _totaljeans4;
                    break;
                case 5:
                    _totaljeans5 += amount;
                    _totalofprice += _pricejeans5 * amount;
                    _totalofitems += _totaljeans5;
                    break;                
            }
        }

        //Update the Cart price
        public override string UpdatePrice(string valpriceCart)
        {
            return valpriceCart = _totalofprice + " $";
        }

        //Update the Cart items
        public override string UpdateItems(string valitemsCart)
        {
            return valitemsCart = _totalofitems + " Items";
        }

        //Recicle Items & Price
        public void RecicleItemsPrice()
        {
            _totaljeans1 = 0;
            _totaljeans2 = 0;
            _totaljeans3 = 0;
            _totaljeans4 = 0;
            _totaljeans5 = 0;
            
            _totalofitems = 0;
            _totalofprice = 0;

            //valpriceCart = _totalofprice + " $";
            //valitemsCart = _totalofitems + " Items";

        }

        //Recicle Items & Price
        /*public void RecicleItemsPrice(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            _totaljeans1 = 0;
            _totaljeans2 = 0;
            _totaljeans3 = 0;
            _totaljeans4 = 0;
            _totaljeans5 = 0;
        }*/

        //Check if numbers in Textbox
        public override bool NumberCheck(string value)
        {
            for (int i = 0; i < _num.Length; i++)
                if ((value).Contains(_num[i])) return false;

            return true;
        }

        #endregion

    }
}
