using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProject
{
    public partial class OrderDesign : Form
    {
        //Panel movement variables    
        private bool mouseDown;
        private Point lastLocation;

        Shop originalForm;

        public OrderDesign(Shop incomingFrom)
        {
            originalForm = incomingFrom;
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = true;
                TheClasses.NewOrder objNewOrder = new TheClasses.NewOrder();
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                #region Address

                //objNewOrder.NullCheck(Address);               
                //Address.Text = Address.Text.ToLower();
                //objNewOrder.UnicodeCheck(Address, 4);
                

                if (objNewOrder.NullCheck(Address.Text) == false)
                {
                    Address.Clear();
                    throw new Exception("Please insert your '" + Address.Name + "' !");
                }

                if (objNewOrder.UnicodeCheck(Address.Text, 4) == false)
                {
                    Address.Clear();
                    throw new Exception("Please insert a correct '" + Address.Name + "' !");
                }

                objNewOrder.Address += textInfo.ToTitleCase(Address.Text);

                #endregion

                #region City

                //objNewOrder.NullCheck(City);
                //City.Text = City.Text.ToLower();
                //objNewOrder.UnicodeCheck(City, 1);
                
                if (objNewOrder.NullCheck(City.Text) == false)
                {
                    City.Clear();
                    throw new Exception("Please insert your '" + City.Name + "' !");
                }

                if (objNewOrder.UnicodeCheck(City.Text, 1) == false)
                {
                    City.Clear();
                    throw new Exception("Please insert a correct '" + City.Name + "' !");
                }

                objNewOrder.City += textInfo.ToTitleCase(City.Text);

                #endregion

                #region Region

                if (objNewOrder.NullCheck(Regionn.Text) == false)
                {
                    Regionn.Clear();
                    throw new Exception("Please insert your '" + Regionn.Name + "' !");
                }

                if (objNewOrder.UnicodeCheck(City.Text, 1) == false)
                {
                    Regionn.Clear();
                    throw new Exception("Please insert a correct '" + Regionn.Name + "' !");
                }

                objNewOrder.Region += textInfo.ToTitleCase(Regionn.Text);

                #endregion

                //Country
                
                #region PostalCode

                if (string.IsNullOrEmpty(PostalCode.Text)) x = false;
                if (x == true)
                {

                    if (objNewOrder.LetterCheck(PostalCode.Text) == false)
                    {
                        PostalCode.Clear();
                        throw new Exception("Please insert a correct '" + PostalCode.Name + "' !");
                    }

                    if (objNewOrder.UnicodeCheck(PostalCode.Text, 0) == false)
                    {
                        PostalCode.Clear();
                        throw new Exception("Please insert a correct '" + PostalCode.Name + "' !");
                    }

                }

                objNewOrder.PostalCode += PostalCode.Text;

                #endregion

                #region Fax

                if (string.IsNullOrEmpty(Fax.Text)) x = false;
                if (x == true)
                {

                    if (objNewOrder.LetterCheck(Fax.Text) == false)
                    {
                        Fax.Clear();
                        throw new Exception("Please insert a correct '" + Fax.Name + "' !");
                    }

                    if (objNewOrder.UnicodeCheck(Fax.Text, 0) == false)
                    {
                        Fax.Clear();
                        throw new Exception("Please insert a correct '" + Fax.Name + "' !");
                    }

                }

                objNewOrder.Fax += Fax.Text;

                #endregion

                //Ship via
                if (Country.SelectedItem != null && ShipVia.SelectedItem != null)
                {
                    objNewOrder.Country += (string)Country.SelectedItem;
                    objNewOrder.ShipVia += (string)ShipVia.SelectedItem;

                    //SQL Command
                    string _command = "INSERT INTO Customer.dbo.Orders (Address,City,Region,Country,PostalCode,Fax,ShipVia,TotalItems,TotalPrice,CustomerId) VALUES('"
                                                                            + objNewOrder.Address + "','"
                                                                            + objNewOrder.City + "','"
                                                                            + objNewOrder.Region + "','"
                                                                            + objNewOrder.Country + "','"
                                                                            + objNewOrder.PostalCode + "','"
                                                                            + objNewOrder.Fax + "','"
                                                                            + objNewOrder.ShipVia + "','"
                                                                            + TheClasses.EntityProducts._totalofitems + "','"
                                                                            + TheClasses.EntityProducts._totalofprice + "','"
                                                                            + LoginDesign.CustomerIdCheck + "')";

                    objNewOrder.InsertReadUpdateData(_command);
                    MessageBox.Show("You have succesfuly placed an order!");
                    this.Close();
                    TheClasses.EntityProducts._totalofitems = 0;
                    TheClasses.EntityProducts._totalofprice = 0;
                    originalForm.cart(TheClasses.EntityProducts._totalofitems.ToString() + " $", TheClasses.EntityProducts._totalofprice.ToString() + " Items");
                }
                else if (Country.SelectedItem == null) MessageBox.Show("Please select a " + Country.Text + "!");   
                else if (ShipVia.SelectedItem == null) MessageBox.Show("Please select a " + ShipVia.Text + " method!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Form panel movement
        private void MouseDownPanel(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void MouseMovePanel(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void MouseUpPanel(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
