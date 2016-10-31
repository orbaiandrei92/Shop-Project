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
    public partial class AccessoriesDesign : Form
    {

        #region Fields Region

        bool mouseDown;
        Point lastLocation;

        Shop originalForm;

        List<Image> AccessoriesList = new List<Image>();

        #endregion

        #region Constructor

        public AccessoriesDesign(Shop incomingFrom, string originalPrice, string originalItems)
        {           
            originalForm = incomingFrom;
            
            InitializeComponent();
            label1.Text = originalPrice;
            label2.Text = originalItems;

            AccessoriesList.Add(Properties.Resources.Accessory0);
            AccessoriesList.Add(Properties.Resources.Accessory1);
            AccessoriesList.Add(Properties.Resources.Accessory2);
            AccessoriesList.Add(Properties.Resources.Accessory3);
            AccessoriesList.Add(Properties.Resources.Accessory4);
            AccessoriesList.Add(Properties.Resources.Accessory5);
        }

        #endregion

        #region Methods Region

        //Form Load features
        private void AccessoriesDesign_Load(object sender, EventArgs e)
        {
            label3.Text = LoginDesign.UserName.Substring(3);

            if (label3.Text.Contains("admin"))
            {

                #region What admin cannot see/use

                ////***Recycle inactive
                RecycleButton.Enabled = false;
                //***AddToCart Buttons
                Bag1Button.Visible = false;
                Bag2Button.Visible = false;
                Jewelry1Button.Visible = false;
                Jewelry2Button.Visible = false;
                WalletButton.Visible = false;
                HatButton.Visible = false;
                //***Amount Label
                AmountLabel1.Visible = false;
                AmountLabel2.Visible = false;
                AmountLabel3.Visible = false;
                AmountLabel4.Visible = false;
                AmountLabel5.Visible = false;
                AmountLabel6.Visible = false;
                //***Amount TextBox
                Bag1TextBox.Visible = false;
                Bag2TextBox.Visible = false;
                Jewelry1TextBox.Visible = false;
                Jewelry2TextBox.Visible = false;
                WalletTextBox.Visible = false;
                HatTextBox.Visible = false;
                //***Best Buy
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                #endregion

                #region What admin can see

                //***New Name
                NewName1.Visible = true;
                NewName2.Visible = true;
                NewName3.Visible = true;
                NewName4.Visible = true;
                NewName5.Visible = true;
                NewName6.Visible = true;
                //***New Price
                NewPrice1.Visible = true;
                NewPrice2.Visible = true;
                NewPrice3.Visible = true;
                NewPrice4.Visible = true;
                NewPrice5.Visible = true;
                NewPrice6.Visible = true;
                //***Change Buttons
                Change1.Visible = true;
                Change2.Visible = true;
                Change3.Visible = true;
                Change4.Visible = true;
                Change5.Visible = true;
                Change6.Visible = true;

                #endregion

            }

            Bag1Label.Text = (string)Properties.Settings.Default["Name1"];
            Bag2Label.Text = (string)Properties.Settings.Default["Name2"];
            Jewelry1Label.Text = (string)Properties.Settings.Default["Name3"];
            Jewelry2Label.Text = (string)Properties.Settings.Default["Name4"];
            WalletLabel.Text = (string)Properties.Settings.Default["Name5"];
            HatLabel.Text = (string)Properties.Settings.Default["Name6"];

            Price1Label.Text = (string)Properties.Settings.Default["Price1"];
            Price2Label.Text = (string)Properties.Settings.Default["Price2"];
            Price3Label.Text = (string)Properties.Settings.Default["Price3"];
            Price4Label.Text = (string)Properties.Settings.Default["Price4"];
            Price5Label.Text = (string)Properties.Settings.Default["Price5"];
            Price6Label.Text = (string)Properties.Settings.Default["Price6"];

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
                        Bag1Label.Text = NewName1.Text;
                        Properties.Settings.Default["Name1"] = Bag1Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice1.Text))
                    {
                        Price1Label.Text = NewPrice1.Text;
                        Properties.Settings.Default["Price1"] = Price1Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName1.Clear();
                    NewPrice1.Clear();
                    break;
                case "Change2":
                    if (!string.IsNullOrEmpty(NewName2.Text))
                    {
                        Bag2Label.Text = NewName2.Text;
                        Properties.Settings.Default["Name2"] = Bag2Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice2.Text))
                    {
                        Price2Label.Text = NewPrice2.Text;
                        Properties.Settings.Default["Price2"] = Price2Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName2.Clear();
                    NewPrice2.Clear();
                    break;
                case "Change3":
                    if (!string.IsNullOrEmpty(NewName3.Text))
                    {
                        Jewelry1Label.Text = NewName3.Text;
                        Properties.Settings.Default["Name3"] = Jewelry1Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice3.Text))
                    {
                        Price3Label.Text = NewPrice3.Text;
                        Properties.Settings.Default["Price3"] = Price3Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName3.Clear();
                    NewPrice3.Clear();
                    break;
                case "Change4":
                    if (!string.IsNullOrEmpty(NewName4.Text))
                    {
                        Jewelry2Label.Text = NewName4.Text;
                        Properties.Settings.Default["Name4"] = Jewelry2Label.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice4.Text))
                    {
                        Price4Label.Text = NewPrice4.Text;
                        Properties.Settings.Default["Price4"] = Price4Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName4.Clear();
                    NewPrice4.Clear();
                    break;
                case "Change5":
                    if (!string.IsNullOrEmpty(NewName5.Text))
                    {
                        WalletLabel.Text = NewName5.Text;
                        Properties.Settings.Default["Name5"] = WalletLabel.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice5.Text))
                    {
                        Price5Label.Text = NewPrice5.Text;
                        Properties.Settings.Default["Price5"] = Price5Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName5.Clear();
                    NewPrice5.Clear();
                    break;
                case "Change6":
                    if (!string.IsNullOrEmpty(NewName6.Text))
                    {
                        HatLabel.Text = NewName6.Text;
                        Properties.Settings.Default["Name6"] = HatLabel.Text;
                    }
                    if (!string.IsNullOrEmpty(NewPrice6.Text))
                    {
                        Price6Label.Text = NewPrice6.Text;
                        Properties.Settings.Default["Price6"] = Price6Label.Text;
                    }
                    Properties.Settings.Default.Save();
                    NewName6.Clear();
                    NewPrice6.Clear();
                    break;
            }

        }

        //What the Client can use
        private void ClientUsage(object sender, EventArgs e)
        {
            try
            {

                TheClasses.ProdAccessories objAccessory = new TheClasses.ProdAccessories();
                int optionclick;
                Button sendingButton = (Button)sender;

                switch (sendingButton.Name)
                {
                    case "Bag1Button":
                        optionclick = 1;
                        objAccessory.NameAccessory1 = Bag1Label.Text;
                        objAccessory.PriceAccessory1 = Convert.ToInt32(Price1Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(Bag1TextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(Bag1TextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Bag1TextBox.Clear();
                        break;
                    case "Bag2Button":
                        optionclick = 2;
                        objAccessory.NameAccessory2 = Bag2Label.Text;
                        objAccessory.PriceAccessory2 = Convert.ToInt32(Price2Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(Bag2TextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(Bag2TextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Bag2TextBox.Clear();
                        break;
                    case "Jewelry1Button":

                        optionclick = 3;
                        objAccessory.NameAccessory3 = Jewelry1Label.Text;
                        objAccessory.PriceAccessory3 = Convert.ToInt32(Price3Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(Jewelry1TextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(Jewelry1TextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jewelry1TextBox.Clear();
                        break;
                    case "Jewelry2Button":
                        optionclick = 4;
                        objAccessory.NameAccessory4 = Jewelry2Label.Text;
                        objAccessory.PriceAccessory4 = Convert.ToInt32(Price4Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(Jewelry2TextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(Jewelry2TextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        Jewelry2TextBox.Clear();
                        break;
                    case "WalletButton":
                        optionclick = 5;
                        objAccessory.NameAccessory5 = WalletLabel.Text;
                        objAccessory.PriceAccessory5 = Convert.ToInt32(Price5Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(WalletTextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(WalletTextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        WalletTextBox.Clear();
                        break;
                    case "HatButton":
                        optionclick = 6;
                        objAccessory.NameAccessory6 = HatLabel.Text;
                        objAccessory.PriceAccessory6 = Convert.ToInt32(Price6Label.Text.Remove(2));

                        if (objAccessory.NumberCheck(HatTextBox.Text) == true)
                        {
                            Bag1TextBox.Clear();
                            throw new Exception("Please insert a correct amount!");
                        }

                        objAccessory.CountPriceAndItems(Convert.ToInt32(HatTextBox.Text), optionclick);
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        HatTextBox.Clear();
                        break;
                    case "RecycleButton":
                        objAccessory.RecicleItemsPrice();
                        label1.Text = objAccessory.UpdatePrice(label1.Text);
                        label2.Text = objAccessory.UpdateItems(label2.Text);
                        originalForm.cart(label1.Text, label2.Text);
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //Method to draw image on mouse enter to pictureboxes
        /*private void DrawImageRectRect(int option)
        {
            // Create a Graphics object for the Control.
            // Graphics g = control.CreateGraphics();

            Graphics g = this.CreateGraphics();

            //Graphics g = e.Graphics;
            Rectangle objRect = new Rectangle(100, 100, 170, 160);
            //Size preferredSize = g.DrawImage(AccessoriesList[option], new Point(50,50));
            //control.ClientSize = new Size(150, 150);
            //control.Location = new Point(control.Width + control.Width / 2, control.Height * 2);
            Pen newPen = new Pen(Color.Black);
            g.DrawImage(AccessoriesList[0], objRect);
            //g.DrawImage(AccessoriesList[0], objRect);
            
            //g.Dispose();
        }*/

        //MouseEnter Events on Pictureboxes
        private void MultipleMouseEnter(object sender, EventArgs e)
        {
            PictureBox sendingBox = (PictureBox)sender;
            
            switch (sendingBox.Name)
            {
                case "Bag1PictureBox":
                    Bag1PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Bag2PictureBox":
                    Bag2PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jewelry1PictureBox":
                    Jewelry1PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "Jewelry2PictureBox":
                    Jewelry2PictureBox.BackColor = Color.SteelBlue;
                    break;
                case "WalletPictureBox":
                    WalletPictureBox.BackColor = Color.SteelBlue;
                    break;
                case "HatPictureBox":
                    HatPictureBox.BackColor = Color.SteelBlue;
                    break;
            }
        }

        //MouseLeave Events on Pictureboxes
        private void MultipleMouseLeave(object sender, EventArgs e)
        {
            PictureBox sendingBox = (PictureBox)sender;
            switch (sendingBox.Name)
            {
                case "Bag1PictureBox":
                    Bag1PictureBox.BackColor = Color.Transparent;
                    break;
                case "Bag2PictureBox":
                    Bag2PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jewelry1PictureBox":
                    Jewelry1PictureBox.BackColor = Color.Transparent;
                    break;
                case "Jewelry2PictureBox":
                    Jewelry2PictureBox.BackColor = Color.Transparent;
                    break;
                case "WalletPictureBox":
                    WalletPictureBox.BackColor = Color.Transparent;
                    break;
                case "HatPictureBox":
                    HatPictureBox.BackColor = Color.Transparent;
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
                    originalForm.enabledisable(1, 1);
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #endregion

    }
}
