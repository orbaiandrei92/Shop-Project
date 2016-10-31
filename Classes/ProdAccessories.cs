using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ProdAccessories : EntityProducts
    {

        #region Field Region

        //Name accessories
        string _accessory1, _accessory2, _accessory3,
               _accessory4, _accessory5, _accessory6;

        //Total accessories
        int _totalaccessory1, _totalaccessory2, _totalaccessory3,
            _totalaccessory4, _totalaccessory5, _totalaccessory6;
        
        //Total price accessories
        int _totalpriceaccessory1, _totalpriceaccessory2, _totalpriceaccessory3,
            _totalpriceaccessory4, _totalpriceaccessory5, _totalpriceaccessory6;
       
        #endregion

        #region Properties Region
        
        //Used to Name/Rename the Accessories
        public string NameAccessory1 { get { return _accessory1; } set { _accessory1 = value; } }
        public string NameAccessory2 { get { return _accessory2; } set { _accessory2 = value; } }
        public string NameAccessory3 { get { return _accessory3; } set { _accessory3 = value; } }
        public string NameAccessory4 { get { return _accessory4; } set { _accessory4 = value; } } 
        public string NameAccessory5 { get { return _accessory5; } set { _accessory5 = value; } }
        public string NameAccessory6 { get { return _accessory6; } set { _accessory6 = value; } }

        //Used to Get/Set the price of each Accessory
        public int PriceAccessory1 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }
        public int PriceAccessory2 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }
        public int PriceAccessory3 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }
        public int PriceAccessory4 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }
        public int PriceAccessory5 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }
        public int PriceAccessory6 { get { return _totalpriceaccessory1; } set { _totalpriceaccessory1 = value; } }

        //Used to Get the number of Accessories 
        public int TotalAccessory1 { get { return _totalaccessory1; } }
        public int TotalAccessory2 { get { return _totalaccessory2; } }
        public int TotalAccessory3 { get { return _totalaccessory3; } }
        public int TotalAccessory4 { get { return _totalaccessory4; } }
        public int TotalAccessory5 { get { return _totalaccessory5; } }
        public int TotalAccessory6 { get { return _totalaccessory6; } }

        #endregion

        #region Constructor

        public ProdAccessories()
        {
            _accessory1 = "Bag 1";
            _accessory2 = "Bag 2";
            _accessory3 = "Jewelry 1";
            _accessory4 = "Jewelry 2";
            _accessory5 = "Wallet";
            _accessory6 = "Hat";

            _totalaccessory1 = 0;
            _totalaccessory2 = 0;
            _totalaccessory3 = 0;
            _totalaccessory4 = 0;
            _totalaccessory5 = 0;
            _totalaccessory6 = 0;

            _totalpriceaccessory1 = 0;
            _totalpriceaccessory2 = 0;
            _totalpriceaccessory3 = 0;
            _totalpriceaccessory4 = 0;
            _totalpriceaccessory5 = 0;
            _totalpriceaccessory6 = 0;
        }

        #endregion

        #region Methods

        //Total price & items method
        public void CountPriceAndItems(string value, int option, int amount)
        {
            switch (option)
            {
                case 1:
                    _totalaccessory1 += amount;
                    _totalpriceaccessory1 += _totalaccessory1 * amount;                                      
                    break;
                case 2:
                    _totalaccessory2 += amount;
                    _totalpriceaccessory2 += _totalaccessory2 * amount;
                    break;
                case 3:
                    _totalaccessory3 += amount;
                    _totalpriceaccessory3 += _totalaccessory3 * amount;
                    break;
                case 4:
                    _totalaccessory4 += amount;
                    _totalpriceaccessory4 += _totalaccessory4 * amount;
                    break;
                case 5:
                    _totalaccessory5 += amount;
                    _totalpriceaccessory5 += _totalaccessory5 * amount;
                    break;
                case 6:
                    _totalaccessory6 += amount;
                    _totalpriceaccessory6 += _totalaccessory6 * amount;
                    break;
            }
        }

        //Update the CartLabels & the MainCartLabels
        public void UpdateLabels(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            valpriceCart = (_totalpriceaccessory6 + _totalpriceaccessory5 + _totalpriceaccessory4 + _totalpriceaccessory3 + _totalpriceaccessory2 + _totalpriceaccessory1) + " $";
            valitemsCart = (_totalaccessory6 + _totalaccessory5 + _totalaccessory4 + _totalaccessory3 + _totalaccessory2 + _totalaccessory1) + " Items";
        }

        //Recicle Items & Price
        public void RecicleItemsPrice(string valpriceCart, string valitemsCart, string valpriceMainCart, string valitemsMainCart)
        {
            _totalaccessory1 = 0;
            _totalaccessory2 = 0;
            _totalaccessory3 = 0;
            _totalaccessory4 = 0;
            _totalaccessory5 = 0;
            _totalaccessory6 = 0;

            _totalpriceaccessory1 = 0;
            _totalpriceaccessory2 = 0;
            _totalpriceaccessory3 = 0;
            _totalpriceaccessory4 = 0;
            _totalpriceaccessory5 = 0;

        }

        #endregion

    }
}
