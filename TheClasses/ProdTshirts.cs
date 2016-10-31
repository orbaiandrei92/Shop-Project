using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public class ProdTshirts : EntityProducts
    {

        #region Field Region

        //Name tshirts
        string _tshirt1, _tshirt2,
               _tshirt3, _tshirt4;

        //Price tshirts
        int _pricetshirt1, _pricetshirt2,
            _pricetshirt3, _pricetshirt4;

        //Total tshirts
        int _totaltshirt1, _totaltshirt2,
            _totaltshirt3, _totaltshirt4;       

        #endregion

        #region Properties Region

        //Used to Name/Rename the Tshirts
        public string NameTshirt1 { get { return _tshirt1; } set { _tshirt1 = value; } }
        public string NameTshirt2 { get { return _tshirt2; } set { _tshirt2 = value; } }
        public string NameTshirt3 { get { return _tshirt3; } set { _tshirt3 = value; } }
        public string NameTshirt4 { get { return _tshirt4; } set { _tshirt4 = value; } }       

        //Used to Get the number of Tshirts 
        public int TotalTshirts1 { get { return _totaltshirt1; } set { _totaltshirt1 = value; } }
        public int TotalTshirts2 { get { return _totaltshirt2; } set { _totaltshirt2 = value; } }
        public int TotalTshirts3 { get { return _totaltshirt3; } set { _totaltshirt3 = value; } }
        public int TotalTshirts4 { get { return _totaltshirt4; } set { _totaltshirt4 = value; } }

        //Used to Get/Set the price of Tshirts 
        public int PriceTshirts1 { get { return _pricetshirt1; } set { _pricetshirt1 = value; } }
        public int PriceTshirts2 { get { return _pricetshirt2; } set { _pricetshirt2 = value; } }
        public int PriceTshirts3 { get { return _pricetshirt3; } set { _pricetshirt3 = value; } }
        public int PriceTshirts4 { get { return _pricetshirt4; } set { _pricetshirt4 = value; } }

        #endregion

        #region Constructor

        public ProdTshirts()
        {
            
            _totaltshirt1 = 0;
            _totaltshirt2 = 0;
            _totaltshirt3 = 0;
            _totaltshirt4 = 0;

        }

        #endregion

        #region Methods

        //Total price & items method (for individual products & total products)
        public override void CountPriceAndItems(int amount, int option)
        {
            switch (option)
            {
                case 1:
                    _totaltshirt1 += amount;
                    _totalofprice += _pricetshirt1 * amount;
                    _totalofitems += _totaltshirt1;                                                     
                    break;
                case 2:
                    _totaltshirt2 += amount;
                    _totalofprice += _pricetshirt2 * amount;
                    _totalofitems += _totaltshirt2;
                    break;
                case 3:
                    _totaltshirt3 += amount;
                    _totalofprice += _pricetshirt3 * amount;
                    _totalofitems += _totaltshirt3;
                    break;
                case 4:
                    _totaltshirt4 += amount;
                    _totalofprice += _pricetshirt4 * amount;
                    _totalofitems += _totaltshirt4;
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
        /*public void RecicleItemsPrice(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            _totaltshirt1 = 0;
            _totaltshirt2 = 0;
            _totaltshirt3 = 0;
            _totaltshirt4 = 0;
           
        }*/

        //Recicle Items & Price
        public void RecicleItemsPrice()
        {
            _totaltshirt1 = 0;
            _totaltshirt2 = 0;
            _totaltshirt3 = 0;
            _totaltshirt4 = 0;

            _totalofitems = 0;
            _totalofprice = 0;

            //valpriceCart = _totalofprice + " $";
            //valitemsCart = _totalofitems + " Items";

        }
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
