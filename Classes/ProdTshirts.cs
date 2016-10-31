using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ProdTshirts
    {

        #region Field Region

        //Name tshirts
        string _tshirt1, _tshirt2,
               _tshirt3, _tshirt4;

        //Total tshirts
        int _totaltshirt1, _totaltshirt2,
            _totaltshirt3, _totaltshirt4;

        //Total price tshirts
        int _totalpricetshirt1, _totalpricetshirt2,
            _totalpricetshirt3, _totalpricetshirt4;

        #endregion

        #region Properties Region

        //Used to Name/Rename the Tshirts
        public string NameTshirt1 { get { return _tshirt1; } set { _tshirt1 = value; } }
        public string NameTshirt2 { get { return _tshirt2; } set { _tshirt2 = value; } }
        public string NameTshirt3 { get { return _tshirt3; } set { _tshirt3 = value; } }
        public string NameTshirt4 { get { return _tshirt4; } set { _tshirt4 = value; } }

        //Used to Get/Set the price of each Tshirt
        public int PriceTshirt1 { get { return _totalpricetshirt1; } set { _totalpricetshirt1 = value; } }
        public int PriceTshirt2 { get { return _totalpricetshirt2; } set { _totalpricetshirt2 = value; } }
        public int PriceTshirt3 { get { return _totalpricetshirt3; } set { _totalpricetshirt3 = value; } }
        public int PriceTshirt4 { get { return _totalpricetshirt4; } set { _totalpricetshirt4 = value; } }

        //Used to Get the number of Tshirts 
        public int TotalTshirts1 { get { return _totaltshirt1; } }
        public int TotalTshirts2 { get { return _totaltshirt2; } }
        public int TotalTshirts3 { get { return _totaltshirt3; } }
        public int TotalTshirts4 { get { return _totaltshirt4; } }

        #endregion

        #region Constructor

        public ProdTshirts()
        {
            _tshirt1 = "T-shirt 1";
            _tshirt2 = "T-shirt 2";
            _tshirt3 = "T-shirt 3";
            _tshirt4 = "T-shirt 4";

            _totaltshirt1 = 0;
            _totaltshirt2 = 0;
            _totaltshirt3 = 0;
            _totaltshirt4 = 0;

            _totalpricetshirt1 = 0;
            _totalpricetshirt2 = 0;
            _totalpricetshirt3 = 0;
            _totalpricetshirt4 = 0;
        }

        #endregion

        #region Methods

        //Total price & items method
        public void CountPriceAndItems(string value, int option, int amount)
        {
            switch (option)
            {
                case 1:
                    _totaltshirt1 += amount;
                    _totalpricetshirt1 += _totaltshirt1 * amount;
                    break;
                case 2:
                    _totaltshirt2 += amount;
                    _totalpricetshirt2 += _totaltshirt2 * amount;
                    break;
                case 3:
                    _totaltshirt3 += amount;
                    _totalpricetshirt3 += _totaltshirt3 * amount;
                    break;
                case 4:
                    _totaltshirt4 += amount;
                    _totalpricetshirt4 += _totaltshirt4 * amount;
                    break;
            }
        }

        //Update the CartLabels & the MainCartLabels
        public void UpdateLabels(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            valpriceCart = (_totalpricetshirt1 + _totalpricetshirt2 + _totalpricetshirt3 + _totalpricetshirt4) + " $";
            valitemsCart = (_totaltshirt1 + _totaltshirt2 + _totaltshirt3 + _totaltshirt4) + " Items";
        }

        //Recicle Items & Price
        public void RecicleItemsPrice(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            _totaltshirt1 = 0;
            _totaltshirt2 = 0;
            _totaltshirt3 = 0;
            _totaltshirt4 = 0;

            _totalpricetshirt1 = 0;
            _totalpricetshirt2 = 0;
            _totalpricetshirt3 = 0;
            _totalpricetshirt4 = 0;
        }

        #endregion

    }
}
