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
    public partial class Shop : Form
    {

        #region Variable Fields

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Used for background
        int change = 0, right = 3, left = 2;
        bool checkb;
        private List<Bitmap> BackgroundList = new List<Bitmap>();

        #endregion

        #region Constructor 

        public Shop()
        {
            InitializeComponent();

            //Adding the other images in the list  
            BackgroundList.Add(Properties.Resources._06_WUUD);//outside of the shop
            BackgroundList.Add(Properties.Resources._02_WUUD);//inside shop (center)
            BackgroundList.Add(Properties.Resources._01_WUUD);//inside shop (left)
            BackgroundList.Add(Properties.Resources._03_WUUD);//inside shop (right)

        }

        #endregion

        #region Methods Region

        //Make Main Form move 
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }       

        //Moving through the shop
        private void ClickEvents(object sender, EventArgs e)
        {
            try
            {
                Button sendingBox = (Button)sender;

                switch (sendingBox.Name)
                {
                    case "EnterShop":
                        change = 1;
                        ChangeBackground(change);
                        checkb = true;

                        LeftArrow.Visible = true;
                        RightArrow.Visible = true;
                        ReturnArrow.Visible = true;
                        EnterShop.Visible = false;
                        ExitShop.Visible = false;
                        Cart.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        Buynow.Visible = true;
                        RecycleButton.Visible = true;
                        Tshirt.Visible = false;
                        Jeans.Visible = false;
                        Accessories.Visible = true;
                        break;

                    case "ExitShop":
                        if (label3.Text.Contains("admin")) MessageBox.Show("Goodbye admin!");
                        else MessageBox.Show("Thanks " + label3.Text + "" + Environment.NewLine + " for shopping at us!");

                        this.Close();
                        LoginDesign objOtherLogin = new LoginDesign();
                        objOtherLogin.Show();                       
                        //Application.Exit();
                        break;

                    case "LeftArrow":
                        if (checkb == true)
                        {
                            checkb = false;
                            ChangeBackground(left);
                            LeftArrow.Visible = false;
                            Jeans.Visible = true;
                            Accessories.Visible = false;
                        }
                        else
                        {
                            ChangeBackground(change);
                            RightArrow.Visible = true;
                            Tshirt.Visible = false;
                            Jeans.Visible = false;
                            Accessories.Visible = true;
                            checkb = true;
                        }
                        break;

                    case "RightArrow":
                        if (checkb == true)
                        {
                            checkb = false;
                            ChangeBackground(right);
                            RightArrow.Visible = false;
                            Tshirt.Visible = true;
                            Accessories.Visible = false;
                        }
                        else
                        {
                            checkb = true;
                            ChangeBackground(change);
                            LeftArrow.Visible = true;
                            Tshirt.Visible = false;
                            Jeans.Visible = false;
                            Accessories.Visible = true;
                            checkb = true;
                        }
                        break;

                    case "ReturnArrow":
                        change = 0;
                        ChangeBackground(change);

                        #region What is/not visible

                        //***Enter/Exit shop
                        EnterShop.Visible = true;
                        ExitShop.Visible = true;

                        //***Arrows
                        LeftArrow.Visible = false;
                        RightArrow.Visible = false;
                        ReturnArrow.Visible = false;
                        //***Cart
                        Cart.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        RecycleButton.Visible = false;
                        Buynow.Visible = false;
                        //***Products           
                        Tshirt.Visible = false;
                        Jeans.Visible = false;
                        Accessories.Visible = false;

                        #endregion

                        TheClasses.EntityProducts._totalofitems = 0;
                        TheClasses.EntityProducts._totalofprice = 0;
                        cart(TheClasses.EntityProducts._totalofitems.ToString() + " $", TheClasses.EntityProducts._totalofprice.ToString() + " Items");
                        break;

                    case "RecycleButton":                       
                        TheClasses.EntityProducts._totalofitems = 0;
                        TheClasses.EntityProducts._totalofprice = 0;
                        cart(TheClasses.EntityProducts._totalofitems.ToString() + " $", TheClasses.EntityProducts._totalofprice.ToString() + " Items");
                        break;

                    case "Jeans":
                        JeansDesign objJeansDesign = new JeansDesign(this, label1.Text, label2.Text);
                        objJeansDesign.Show();
                        enabledisable(2, 0);
                        break;

                    case "Tshirt":
                        TshirtsDesign objTshirtsDesign = new TshirtsDesign(this, label1.Text, label2.Text);
                        objTshirtsDesign.Show();
                        enabledisable(3, 0);
                        break;

                    case "Accessories":
                        AccessoriesDesign objAccessoriesDesign = new AccessoriesDesign(this, label1.Text, label2.Text);
                        objAccessoriesDesign.Show();
                        enabledisable(1, 0);
                        break;

                    case "Buynow":                        
                            if (label3.Text.Contains("admin")) throw new Exception("Admin cannot place an order!");

                            if (TheClasses.EntityProducts._totalofitems == 0)
                            {
                                MessageBox.Show("You cannot place an order! " + Environment.NewLine + " There are no items in your Cart!");
                            }
                            else
                            {
                                OrderDesign objOrderDesign = new OrderDesign(this);
                                objOrderDesign.Show();
                            }                                                                                            
                        break;

                    case "DetailsButton":
                        DetailsDesign objDetailsDesign = new DetailsDesign(this);
                        objDetailsDesign.Show();
                        enabledisable(4, 0);
                        break;
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Change background method
        private void ChangeBackground(int value)
        {
            this.BackgroundImage = BackgroundList[value];
        }

        //Update the main cart
        internal void cart(string mainPrice, string mainItems)
        {
            label1.Text = mainPrice;
            label2.Text = mainItems;
        }

        //Enable-Disable tools
        internal void enabledisable(int option, int EnableOrDisable)
        {
            switch (EnableOrDisable)
            {
                case 0:
                    switch (option)
                    {
                        case 1:
                            LeftArrow.Enabled = false;
                            RightArrow.Enabled = false;
                            Buynow.Enabled = false;
                            ReturnArrow.Enabled = false;
                            DetailsButton.Enabled = false;
                            Accessories.Enabled = false;
                            RecycleButton.Enabled = false;
                            break;
                        case 2:
                            RightArrow.Enabled = false;
                            Buynow.Enabled = false;
                            ReturnArrow.Enabled = false;
                            DetailsButton.Enabled = false;
                            Jeans.Enabled = false;
                            RecycleButton.Enabled = false;
                            break;
                        case 3:
                            LeftArrow.Enabled = false;
                            Buynow.Enabled = false;
                            ReturnArrow.Enabled = false;
                            DetailsButton.Enabled = false;
                            Tshirt.Enabled = false;
                            RecycleButton.Enabled = false;
                            break;
                        case 4:
                            ExitShop.Enabled = false;
                            EnterShop.Enabled = false;
                            break;
                    }
            break;
                case 1:
                    switch (option)
                    {
                        case 1:
                            LeftArrow.Enabled = true;
                            RightArrow.Enabled = true;
                            Buynow.Enabled = true;
                            ReturnArrow.Enabled = true;
                            DetailsButton.Enabled = true;
                            Accessories.Enabled = true;
                            RecycleButton.Enabled = true;
                            break;
                        case 2:
                            RightArrow.Enabled = true;
                            Buynow.Enabled = true;
                            ReturnArrow.Enabled = true;
                            DetailsButton.Enabled = true;
                            Jeans.Enabled = true;
                            RecycleButton.Enabled = true;
                            break;
                        case 3:
                            LeftArrow.Enabled = true;
                            Buynow.Enabled = true;
                            ReturnArrow.Enabled = true;
                            DetailsButton.Enabled = true;
                            Tshirt.Enabled = true;
                            RecycleButton.Enabled = true;
                            break;
                        case 4:
                            ExitShop.Enabled = true;
                            EnterShop.Enabled = true;
                            break;
                    }
                    break;
            }
        }

        //Shop From Load features
        private void Shop_Load(object sender, EventArgs e)
        {
            label3.Text = LoginDesign.UserName.Substring(3);
            label3.ForeColor = System.Drawing.Color.Red;

            //Check if admin is logged
            if (label3.Text.Contains("admin"))
            {
                DetailsButton.Visible = true;
            }

            ChangeBackground(change);

            LeftArrow.Visible = false;
            RightArrow.Visible = false;
            ReturnArrow.Visible = false;
            Cart.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            
            //UserNameLabel.Visible = true;
            //UserNameLabel.Text = Loggin.UserName;
            //UserNameLabel.ForeColor = System.Drawing.Color.Red;
            //label5.Visible = true;
            Tshirt.Visible = false;
            Jeans.Visible = false;
            Accessories.Visible = false;
            Buynow.Visible = false;
            RecycleButton.Visible = false;

        }

        #endregion

    }
}
