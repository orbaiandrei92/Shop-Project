using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProject
{
    public partial class TshirtsDesign : Form
    {

        #region Fields Region

        bool mouseDown;
        Point lastLocation;

        Shop originalForm;

        #endregion

        #region Constructor

        public TshirtsDesign(Shop incomingFrom, string originalPrice, string originalItems)
        {
            originalForm = incomingFrom;
            InitializeComponent();
            label1.Text = originalPrice;
            label2.Text = originalItems;
        }

        #endregion

        #region Methods Region

        //Form Load features
        private void TshirtsDesign_Load(object sender, EventArgs e)
        {
            label3.Text = LoginDesign.UserName.Substring(3);

            if (label3.Text.Contains("admin"))
            {

                #region What admin cannot see/use

                //***Recycle inactive
                RecycleButton.Enabled = false;
                //***AddToCart Buttons
                Tshirt1Button.Visible = false;
                Tshirt2Button.Visible = false;
                Tshirt3Button.Visible = false;
                Tshirt4Button.Visible = false;
                //***Amount Label
                AmountLabel1.Visible = false;
                AmountLabel2.Visible = false;
                AmountLabel3.Visible = false;
                AmountLabel4.Visible = false;
                //***Amount TextBox
                Tshirt1TextBox.Visible = false;
                Tshirt2TextBox.Visible = false;
                Tshirt3TextBox.Visible = false;
                Tshirt4TextBox.Visible = false;
                //***Best Buy
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                #endregion

                #region What admin can see

                //***New Name
                NewName1.Visible = true;
                NewName2.Visible = true;
                NewName3.Visible = true;
                NewName4.Visible = true;
                //***New Price
                NewPrice1.Visible = true;
                NewPrice2.Visible = true;
                NewPrice3.Visible = true;
                NewPrice4.Visible = true;
                //***Change Buttons
                Change1.Visible = true;
                Change2.Visible = true;
                Change3.Visible = true;
                Change4.Visible = true;

                #endregion

            }

            Tshirt1Label.Text = (string)Properties.Settings.Default["Name12"];
            Tshirt2Label.Text = (string)Properties.Settings.Default["Name13"];
            Tshirt3Label.Text = (string)Properties.Settings.Default["Name14"];
            Tshirt4Label.Text = (string)Properties.Settings.Default["Name15"];

            Price1Label.Text = (string)Properties.Settings.Default["Price12"];
            Price2Label.Text = (string)Properties.Settings.Default["Price13"];
            Price3Label.Text = (string)Properties.Settings.Default["Price14"];
            Price4Label.Text = (string)Properties.Settings.Default["Price15"];

        }

        //What the Admin can use
        private void AdminButtons(object sender, EventArgs e)
        {
            Button sendingBox = (Button)sender;

            switch (sendingBox.Name)
            {
                case "Change1":
                    if (!string.IsNullOrEmpty(NewName1.Text))
                    {
                        Tshirt1Label.Text = NewName1.Text;
                        Properties.Settings.Default["Name12"] = Tshirt1Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice1.Text))
                    {
                        Price1Label.Text = NewPrice1.Text;
                        Properties.Settings.Default["Price12"] = Price1Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName1.Clear();
                    NewPrice1.Clear();
                    break;
                case "Change2":
                    if (!string.IsNullOrEmpty(NewName2.Text))
                    {
                        Tshirt2Label.Text = NewName2.Text;
                        Properties.Settings.Default["Name13"] = Tshirt2Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice2.Text))
                    {
                        Price2Label.Text = NewPrice2.Text;
                        Properties.Settings.Default["Price13"] = Price2Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName2.Clear();
                    NewPrice2.Clear();
                    break;
                case "Change3":
                    if (!string.IsNullOrEmpty(NewName3.Text))
                    {
                        Tshirt3Label.Text = NewName3.Text;
                        Properties.Settings.Default["Name14"] = Tshirt3Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice3.Text))
                    {
                        Price3Label.Text = NewPrice3.Text;
                        Properties.Settings.Default["Price14"] = Price3Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName3.Clear();
                    NewPrice3.Clear();
                    break;
                case "Change4":
                    if (!string.IsNullOrEmpty(NewName4.Text))
                    {
                        Tshirt4Label.Text = NewName4.Text;
                        Properties.Settings.Default["Name15"] = Tshirt4Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice4.Text))
                    {
                        Price4Label.Text = NewPrice4.Text;
                        Properties.Settings.Default["Price15"] = Price4Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName4.Clear();
                    NewPrice4.Clear();
                    break;

            }

        }

        //What the Client can use
        public void AddToCart(object sender, EventArgs e)
        {
            try
            {

                TheClasses.ProdTshirts objTshirt = new TheClasses.ProdTshirts();
                int optionclick;
                Button sendingBox = (Button)sender;

                switch (sendingBox.Name)
                {
                    case "Tshirt1Button":
                        optionclick = 1;
                        objTshirt.NameTshirt1 = Tshirt1Label.Text;
                        objTshirt.PriceTshirts1 = Convert.ToInt32(Price1Label.Text.Remove(2));

                        if (objTshirt.NumberCheck(Tshirt1TextBox.Text) == true)
                        {
                            Tshirt1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objTshirt.CountPriceAndItems(Convert.ToInt32(Tshirt1TextBox.Text), optionclick);
                        label1.Text = objTshirt.UpdatePrice(label1.Text);
                        label2.Text = objTshirt.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Tshirt1TextBox.Clear();
                        
                        break;
                    case "Tshirt2Button":
                        optionclick = 2;
                        objTshirt.NameTshirt2 = Tshirt2Label.Text;
                        objTshirt.PriceTshirts2 = Convert.ToInt32(Price2Label.Text.Remove(2));

                        if (objTshirt.NumberCheck(Tshirt2TextBox.Text) == true)
                        {
                            Tshirt2TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objTshirt.CountPriceAndItems(Convert.ToInt32(Tshirt2TextBox.Text), optionclick);
                        label1.Text = objTshirt.UpdatePrice(label1.Text);
                        label2.Text = objTshirt.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Tshirt2TextBox.Clear();
                        break;
                    case "Tshirt3Button":
                        optionclick = 3;
                        objTshirt.NameTshirt3 = Tshirt3Label.Text;
                        objTshirt.PriceTshirts3 = Convert.ToInt32(Price3Label.Text.Remove(2));

                        if (objTshirt.NumberCheck(Tshirt3TextBox.Text) == true)
                        {
                            Tshirt3TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objTshirt.CountPriceAndItems(Convert.ToInt32(Tshirt3TextBox.Text), optionclick);
                        label1.Text = objTshirt.UpdatePrice(label1.Text);
                        label2.Text = objTshirt.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Tshirt3TextBox.Clear();
                        break;
                    case "Tshirt4Button":
                        optionclick = 4;
                        objTshirt.NameTshirt4 = Tshirt4Label.Text;
                        objTshirt.PriceTshirts4 = Convert.ToInt32(Price4Label.Text.Remove(2));

                        if (objTshirt.NumberCheck(Tshirt4TextBox.Text) == true)
                        {
                            Tshirt4TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objTshirt.CountPriceAndItems(Convert.ToInt32(Tshirt4TextBox.Text), optionclick);
                        label1.Text = objTshirt.UpdatePrice(label1.Text);
                        label2.Text = objTshirt.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Tshirt4TextBox.Clear();
                        break;
                    case "RecycleButton":
                        //objTshirt.TotalTshirts1 = 0;
                        //objTshirt.TotalTshirts2 = 0;
                        //objTshirt.TotalTshirts3 = 0;
                        //objTshirt.TotalTshirts4 = 0;
                        //objTshirt.TotalOfItems = 0;
                        //objTshirt.TotalOfPrice = 0;
                        objTshirt.RecicleItemsPrice();
                        label1.Text = objTshirt.UpdatePrice(label1.Text);
                        label2.Text = objTshirt.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //MouseEnter Events on Pictureboxes
        private void MultipleMouseEnter(object sender, EventArgs e)
        {
            PictureBox sendingBox = (PictureBox)sender;
            switch (sendingBox.Name)
            {
                case "Tshirt1PictureBox":
                    Tshirt1PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Tshirt2PictureBox":
                    Tshirt2PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Tshirt3PictureBox":
                    Tshirt3PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Tshirt4PictureBox":
                    Tshirt4PictureBox.BackColor = Color.SteelBlue;
                    break;
            }
        }

        //MouseLeave Events on Pictureboxes
        private void MultipleMouseLeave(object sender, EventArgs e)
        {
            PictureBox sendingBox = (PictureBox)sender;
            switch (sendingBox.Name)
            {
                case "Tshirt1PictureBox":
                    Tshirt1PictureBox.BackColor = Color.Transparent;
                    break;
                case "Tshirt2PictureBox":
                    Tshirt2PictureBox.BackColor = Color.Transparent;
                    break;
                case "Tshirt3PictureBox":
                    Tshirt3PictureBox.BackColor = Color.Transparent;
                    break;
                case "Tshirt4PictureBox":
                    Tshirt4PictureBox.BackColor = Color.Transparent;
                    break;
            }
        }

        //Form panel movement
        public void MouseDownPanel(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        public void MouseMovePanel(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        public void MouseUpPanel(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
               
        //Exit & Minimize Form
        private void ExitMinimize(object sender, EventArgs e)
        {
            Button sendingButton = (Button)sender;
            switch (sendingButton.Name)
            {
                case "ExitButton":
                    this.Close();
                    originalForm.enabledisable(3, 1);
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #endregion

    }
}
