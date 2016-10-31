using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ProdJeans
    {

        #region Field Region

        //Name jeans
        string _jeans1, _jeans2, _jeans3,
               _jeans4, _jeans5;

        //Total jeans
        int _totaljeans1, _totaljeans2, _totaljeans3,
            _totaljeans4, _totaljeans5;

        //Total price accessories
        int _totalpricejeans1, _totalpricejeans2, _totalpricejeans3,
            _totalpricejeans4, _totalpricejeans5;

        #endregion

        #region Properties Region

        //Used to Name/Rename the Jeans
        public string NameJeans1 { get { return _jeans1; } set { _jeans1 = value; } }
        public string NameJeans2 { get { return _jeans2; } set { _jeans2 = value; } }
        public string NameJeans3 { get { return _jeans3; } set { _jeans3 = value; } }
        public string NameJeans4 { get { return _jeans4; } set { _jeans4 = value; } }
        public string NameJeans5 { get { return _jeans5; } set { _jeans5 = value; } }       

        //Used to Get/Set the price of each Jeans
        public int PriceJeans1 { get { return _totalpricejeans1; } set { _totalpricejeans1 = value; } }
        public int PriceJeans2 { get { return _totalpricejeans2; } set { _totalpricejeans2 = value; } }
        public int PriceJeans3 { get { return _totalpricejeans3; } set { _totalpricejeans3 = value; } }
        public int PriceJeans4 { get { return _totalpricejeans4; } set { _totalpricejeans4 = value; } }
        public int PriceJeans5 { get { return _totalpricejeans5; } set { _totalpricejeans5 = value; } }

        //Used to Get the number of Jeans 
        public int TotalJeans1 { get { return _totaljeans1; } }
        public int TotalJeans2 { get { return _totaljeans2; } }
        public int TotalJeans3 { get { return _totaljeans3; } }
        public int TotalJeans4 { get { return _totaljeans4; } }
        public int TotalJeans5 { get { return _totaljeans5; } }

        #endregion

        #region Constructor

        public ProdJeans()
        {
            _jeans1 = "Jeans 1";
            _jeans2 = "Jeans 2";
            _jeans3 = "Jeans 3";
            _jeans4 = "Jeans 4";
            _jeans5 = "Jeans 5";

            _totaljeans1 = 0;
            _totaljeans2 = 0;
            _totaljeans3 = 0;
            _totaljeans4 = 0;
            _totaljeans5 = 0;           

            _totalpricejeans1 = 0;
            _totalpricejeans2 = 0;
            _totalpricejeans3 = 0;
            _totalpricejeans4 = 0;
            _totalpricejeans5 = 0;
        }

        #endregion

        #region Methods

        //Total price & items method
        public void CountPriceAndItems(int option, int amount)
        {
            switch (option)
            {
                case 1:
                    _totaljeans1 += amount;
                    _totalpricejeans1 += _totaljeans1 * amount;
                    break;
                case 2:
                    _totaljeans2 += amount;
                    _totalpricejeans2 += _totaljeans2 * amount;
                    break;
                case 3:
                    _totaljeans3 += amount;
                    _totalpricejeans3 += _totaljeans3 * amount;
                    break;
                case 4:
                    _totaljeans4 += amount;
                    _totalpricejeans4 += _totaljeans4 * amount;
                    break;
                case 5:
                    _totaljeans5 += amount;
                    _totalpricejeans5 += _totaljeans5 * amount;
                    break;                
            }
        }

        //Update the CartLabels & the MainCartLabels
        public void UpdateLabels(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            valpriceCart = (_totalpricejeans1 + _totalpricejeans2 + _totalpricejeans3 + _totalpricejeans4 + _totalpricejeans5) + " $";
            valitemsCart = (_totaljeans1 + _totaljeans2 + _totaljeans3 + _totaljeans4 + _totaljeans5) + " Items";
        }

        //Recicle Items & Price
        public void RecicleItemsPrice(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            _totaljeans1 = 0;
            _totaljeans2 = 0;
            _totaljeans3 = 0;
            _totaljeans4 = 0;
            _totaljeans5 = 0;

            _totalpricejeans1 = 0;
            _totalpricejeans2 = 0;
            _totalpricejeans3 = 0;
            _totalpricejeans4 = 0;
            _totalpricejeans5 = 0;
        }

        #endregion

    }
}
