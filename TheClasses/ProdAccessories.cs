using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public class ProdAccessories : EntityProducts
    {

        #region Field Region

        //Total accessories
        int _totalaccessory1, _totalaccessory2, _totalaccessory3,
            _totalaccessory4, _totalaccessory5, _totalaccessory6;

        //Price accessories
        int _priceaccessory1, _priceaccessory2, _priceaccessory3,
            _priceaccessory4, _priceaccessory5, _priceaccessory6;       

        #endregion

        #region Properties Region

        //Used to Name/Rename the Accessories
        public string NameAccessory1 { get;  set; }
        public string NameAccessory2 { get; set; }
        public string NameAccessory3 { get; set; }
        public string NameAccessory4 { get; set; }
        public string NameAccessory5 { get; set; }
        public string NameAccessory6 { get; set; }

        //Used to Get/Set the price of each Accessory
        public int PriceAccessory1 { get { return _priceaccessory1; } set { _priceaccessory1 = value; } }
        public int PriceAccessory2 { get { return _priceaccessory2; } set { _priceaccessory2 = value; } }
        public int PriceAccessory3 { get { return _priceaccessory3; } set { _priceaccessory3 = value; } }
        public int PriceAccessory4 { get { return _priceaccessory4; } set { _priceaccessory4 = value; } }
        public int PriceAccessory5 { get { return _priceaccessory5; } set { _priceaccessory5 = value; } }
        public int PriceAccessory6 { get { return _priceaccessory6; } set { _priceaccessory6 = value; } }

        //Used to Get the number of Accessories 
        public int TotalAccessory1 { get { return _totalaccessory1; } set { _totalaccessory1 = value; } }
        public int TotalAccessory2 { get { return _totalaccessory2; } set { _totalaccessory2 = value; } }
        public int TotalAccessory3 { get { return _totalaccessory3; } set { _totalaccessory3 = value; } }
        public int TotalAccessory4 { get { return _totalaccessory4; } set { _totalaccessory4 = value; } }
        public int TotalAccessory5 { get { return _totalaccessory5; } set { _totalaccessory5 = value; } }
        public int TotalAccessory6 { get { return _totalaccessory6; } set { _totalaccessory6 = value; } }

        #endregion

        #region Constructor

        public ProdAccessories()
        {
                        
            _totalaccessory1 = 0;
            _totalaccessory2 = 0;
            _totalaccessory3 = 0;
            _totalaccessory4 = 0;
            _totalaccessory5 = 0;
            _totalaccessory6 = 0;           

        }

        #endregion

        #region Methods

        //Total price & items method (for individual products & total products)
        public override void CountPriceAndItems(int amount, int option)
        {
            switch (option)
            {
                case 1:
                    _totalaccessory1 += amount;
                    _totalofprice += _priceaccessory1 * amount;
                    _totalofitems += _totalaccessory1;
                    break;
                case 2:
                    _totalaccessory2 += amount;
                    _totalofprice += _priceaccessory2 * amount;
                    _totalofitems += _totalaccessory2;
                    break;
                case 3:
                    _totalaccessory3 += amount;
                    _totalofprice += _priceaccessory3 * amount;
                    _totalofitems += _totalaccessory3;
                    break;
                case 4:
                    _totalaccessory4 += amount;
                    _totalofprice += _priceaccessory4 * amount;
                    _totalofitems += _totalaccessory4;
                    break;
                case 5:
                    _totalaccessory5 += amount;
                    _totalofprice += _priceaccessory5 * amount;
                    _totalofitems += _totalaccessory5;
                    break;
                case 6:
                    _totalaccessory6 += amount;
                    _totalofprice += _priceaccessory6 * amount;
                    _totalofitems += _totalaccessory6;
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
            _totalaccessory1 = 0;
            _totalaccessory2 = 0;
            _totalaccessory3 = 0;
            _totalaccessory4 = 0;
            _totalaccessory5 = 0;
            _totalaccessory6 = 0;

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
