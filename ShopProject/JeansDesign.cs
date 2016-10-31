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
    public partial class JeansDesign : Form
    {

        #region Fields Region

        bool mouseDown;
        Point lastLocation;

        Shop originalForm;

        #endregion

        #region Constructor

        public JeansDesign(Shop incomingFrom, string originalPrice, string originalItems)
        {
            originalForm = incomingFrom;
            InitializeComponent();
            label1.Text = originalPrice;
            label2.Text = originalItems;
        }

        #endregion

        #region Methods Region

        //Form Load features
        private void JeansDesign_Load(object sender, EventArgs e)
        {
            label3.Text = LoginDesign.UserName.Substring(3);

            if (label3.Text.Contains("admin"))
            {

                #region What admin cannot see/use

                //***Recycle inactive
                RecycleButton.Enabled = false;
                //***AddToCart Buttons
                Jeans1Button.Visible = false;
                Jeans2Button.Visible = false;
                Jeans3Button.Visible = false;
                Jeans4Button.Visible = false;
                Jeans5Button.Visible = false;
                //***Amount Label
                AmountLabel1.Visible = false;
                AmountLabel2.Visible = false;
                AmountLabel3.Visible = false;
                AmountLabel4.Visible = false;
                AmountLabel5.Visible = false;
                //***Amount TextBox
                Jeans1TextBox.Visible = false;
                Jeans2TextBox.Visible = false;
                Jeans3TextBox.Visible = false;
                Jeans4TextBox.Visible = false;
                Jeans5TextBox.Visible = false;
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
                NewName5.Visible = true;
                //***New Price
                NewPrice1.Visible = true;
                NewPrice2.Visible = true;
                NewPrice3.Visible = true;
                NewPrice4.Visible = true;
                NewPrice5.Visible = true;
                //***Change Buttons
                Change1.Visible = true;
                Change2.Visible = true;
                Change3.Visible = true;
                Change4.Visible = true;
                Change5.Visible = true;

                #endregion

            }

            Jeans1Label.Text = (string)Properties.Settings.Default["Name7"];
            Jeans2Label.Text = (string)Properties.Settings.Default["Name8"];
            Jeans3Label.Text = (string)Properties.Settings.Default["Name9"];
            Jeans4Label.Text = (string)Properties.Settings.Default["Name10"];
            Jeans5Label.Text = (string)Properties.Settings.Default["Name11"];

            Price1Label.Text = (string)Properties.Settings.Default["Price7"];
            Price2Label.Text = (string)Properties.Settings.Default["Price8"];
            Price3Label.Text = (string)Properties.Settings.Default["Price9"];
            Price4Label.Text = (string)Properties.Settings.Default["Price10"];
            Price5Label.Text = (string)Properties.Settings.Default["Price11"];

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
                        Jeans1Label.Text = NewName1.Text;
                        Properties.Settings.Default["Name7"] = Jeans1Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice1.Text))
                    {
                        Price1Label.Text = NewPrice1.Text;
                        Properties.Settings.Default["Price7"] = Price1Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName1.Clear();
                    NewPrice1.Clear();
                    break;
                case "Change2":
                    if (!string.IsNullOrEmpty(NewName2.Text))
                    {
                        Jeans2Label.Text = NewName2.Text;
                        Properties.Settings.Default["Name8"] = Jeans2Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice2.Text))
                    {
                        Price2Label.Text = NewPrice2.Text;
                        Properties.Settings.Default["Price8"] = Price2Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName2.Clear();
                    NewPrice2.Clear();
                    break;
                case "Change3":
                    if (!string.IsNullOrEmpty(NewName3.Text))
                    {
                        Jeans3Label.Text = NewName3.Text;
                        Properties.Settings.Default["Name9"] = Jeans3Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice3.Text))
                    {
                        Price3Label.Text = NewPrice3.Text;
                        Properties.Settings.Default["Price9"] = Price3Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName3.Clear();
                    NewPrice3.Clear();
                    break;
                case "Change4":
                    if (!string.IsNullOrEmpty(NewName4.Text))
                    {
                        Jeans4Label.Text = NewName4.Text;
                        Properties.Settings.Default["Name10"] = Jeans4Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice4.Text))
                    {
                        Price4Label.Text = NewPrice4.Text;
                        Properties.Settings.Default["Price10"] = Price4Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName4.Clear();
                    NewPrice4.Clear();
                    break;
                case "Change5":
                    if (!string.IsNullOrEmpty(NewName5.Text))
                    {
                        Jeans5Label.Text = NewName5.Text;
                        Properties.Settings.Default["Name11"] = Jeans5Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice5.Text))
                    {
                        Price5Label.Text = NewPrice5.Text;
                        Properties.Settings.Default["Price11"] = Price5Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName5.Clear();
                    NewPrice5.Clear();
                    break;

            }

        }

        //What the Client can use
        public void AddToCart(object sender, EventArgs e)
        {
            try
            {

                TheClasses.ProdJeans objJeans = new TheClasses.ProdJeans();
                int optionclick;
                Button sendingBox = (Button)sender;

                switch (sendingBox.Name)
                {
                    case "Jeans1Button":
                        optionclick = 1;
                        objJeans.NameJeans1 = Convert.ToString(Jeans1Label.Text);
                        objJeans.PriceJeans1 = Convert.ToInt32(Price1Label.Text.Remove(2));

                        if (objJeans.NumberCheck(Jeans1TextBox.Text) == true)
                        {
                            Jeans1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objJeans.CountPriceAndItems(Convert.ToInt32(Jeans1TextBox.Text), optionclick);
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jeans1TextBox.Clear();                      
                        break;
                    case "Jeans2Button":
                        optionclick = 2;
                        objJeans.NameJeans2 = Convert.ToString(Jeans2Label.Text);
                        objJeans.PriceJeans2 = Convert.ToInt32(Price2Label.Text.Remove(2));

                        if (objJeans.NumberCheck(Jeans2TextBox.Text) == true)
                        {
                            Jeans2TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objJeans.CountPriceAndItems(Convert.ToInt32(Jeans2TextBox.Text), optionclick);
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jeans2TextBox.Clear();
                        break;
                    case "Jeans3Button":
                        optionclick = 3;
                        objJeans.NameJeans3 = Convert.ToString(Jeans3Label.Text);
                        objJeans.PriceJeans3 = Convert.ToInt32(Price3Label.Text.Remove(2));

                        if (objJeans.NumberCheck(Jeans3TextBox.Text) == true)
                        {
                            Jeans3TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objJeans.CountPriceAndItems(Convert.ToInt32(Jeans3TextBox.Text), optionclick);
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jeans3TextBox.Clear();
                        break;
                    case "Jeans4Button":
                        optionclick = 4;
                        objJeans.NameJeans4 = Convert.ToString(Jeans4Label.Text);
                        objJeans.PriceJeans4 = Convert.ToInt32(Price4Label.Text.Remove(2));

                        if (objJeans.NumberCheck(Jeans4TextBox.Text) == true)
                        {
                            Jeans4TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objJeans.CountPriceAndItems(Convert.ToInt32(Jeans4TextBox.Text), optionclick);
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jeans4TextBox.Clear();
                        break;
                    case "Jeans5Button":
                        optionclick = 5;
                        objJeans.NameJeans5 = Convert.ToString(Jeans5Label.Text);
                        objJeans.PriceJeans5 = Convert.ToInt32(Price5Label.Text.Remove(2));

                        if (objJeans.NumberCheck(Jeans5TextBox.Text) == true)
                        {
                            Jeans5TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }
                        
                        objJeans.CountPriceAndItems(Convert.ToInt32(Jeans5TextBox.Text), optionclick);
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jeans5TextBox.Clear();
                        break;
                    case "RecycleButton":
                        //objJeans.TotalJeans1 = 0;
                        //objJeans.TotalJeans2 = 0;
                        //objJeans.TotalJeans3 = 0;
                        //objJeans.TotalJeans4 = 0;
                        //objJeans.TotalJeans5 = 0;
                        //objJeans.TotalOfItems = 0;
                        //objJeans.TotalOfPrice = 0;
                        objJeans.RecicleItemsPrice();
                        label1.Text = objJeans.UpdatePrice(label1.Text);
                        label2.Text = objJeans.UpdateItems(label2.Text);
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
                case "Jeans1PictureBox":
                    Jeans1PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jeans2PictureBox":
                    Jeans2PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jeans3PictureBox":
                    Jeans3PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jeans4PictureBox":
                    Jeans4PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jeans5PictureBox":
                    Jeans5PictureBox.BackColor = Color.SteelBlue;
                    break;
            }
        }

        //MouseLeave Events on Pictureboxes
        private void MultipleMouseLeave(object sender, EventArgs e)
        {
            PictureBox sendingBox = (PictureBox)sender;
            switch (sendingBox.Name)
            {
                case "Jeans1PictureBox":
                    Jeans1PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jeans2PictureBox":
                    Jeans2PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jeans3PictureBox":
                    Jeans3PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jeans4PictureBox":
                    Jeans4PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jeans5PictureBox":
                    Jeans5PictureBox.BackColor = Color.Transparent;
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
                    originalForm.enabledisable(2, 1);
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #endregion

    }
}
