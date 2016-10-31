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
using WinForms_EntityFramework;


namespace ShopProject
{
    public partial class SignUpDesign : Form
    {

        #region Fields Region

        bool mouseDown;
        Point lastLocation;

        LoginDesign originalForm;

        #endregion

        #region Constructor

        public SignUpDesign(LoginDesign incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        #endregion

        #region Methods       

        //Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            originalForm.enabledisable(1);
        }

        //Minimize Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       

        //SignUp Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               

                bool x = true;
                TheClasses.NewClient objNewClient = new TheClasses.NewClient();
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                
                #region Firstname

                //objNewClient.NullCheck(Firstname);
                //Firstname.Text = Firstname.Text.ToLower();
                //objNewClient.NumberCheck(Firstname);
                //objNewClient.UnicodeCheck(Firstname, 0);
                //objNewClient.FName += objNewClient.CapitalizeFirstLetter(Firstname.Text);

                if (objNewClient.NullCheck(Firstname.Text) == false)
                {
                    Firstname.Clear();
                    throw new Exception("Please insert your '" + Firstname.Name + "' !");
                }
                
                if (objNewClient.NumberCheck(Firstname.Text) == false)
                {
                    Firstname.Clear();
                    throw new Exception("Please insert a correct '" + Firstname.Name + "' !");
                }

                if (objNewClient.UnicodeCheck(Firstname.Text, 0) == false)
                {
                    Firstname.Clear();
                    throw new Exception("Please insert a correct '" + Firstname.Name + "' !");
                }

                objNewClient.FName += textInfo.ToTitleCase(Firstname.Text);

                #endregion

                #region Lastname

                //objNewClient.NullCheck(Lastname);
                //Lastname.Text = Lastname.Text.ToLower();                                             
                //objNewClient.NumberCheck(Lastname);
                //objNewClient.UnicodeCheck(Lastname, 1);

                if (objNewClient.NullCheck(Lastname.Text) == false)
                {
                    Lastname.Clear();
                    throw new Exception("Please insert your '" + Lastname.Name + "' !");
                }

                if (objNewClient.NumberCheck(Lastname.Text) == false)
                {
                    Lastname.Clear();
                    throw new Exception("Please insert a correct '" + Lastname.Name + "' !");
                }

                if (objNewClient.UnicodeCheck(Lastname.Text, 1) == false)
                {
                    Lastname.Clear();
                    throw new Exception("Please insert a correct '" + Lastname.Name + "' !");
                }
                
                objNewClient.LName += textInfo.ToTitleCase(Lastname.Text);

                #endregion

                #region Email

                //objNewClient.NullCheck(Email);
                //Email.Text = Email.Text.ToLower();               
                //objNewClient.EmailCheck(Email);

                if (objNewClient.NullCheck(Email.Text) == false)
                {
                    Email.Clear();
                    throw new Exception("Please insert your '" + Email.Name + "' !");
                }

                if (objNewClient.EmailCheck(Email.Text) == true)
                {
                    Email.Clear();
                    throw new Exception("Please insert a correct Email! (...@yahoo.com/@gmail.com)");
                }
                
                objNewClient.Email += Email.Text;

                #endregion

                #region Phone
               
                //objNewClient.PhoneCheck(Phone);

                if (string.IsNullOrEmpty(Phone.Text)) x = false;
                if (x == true)
                {

                    if (objNewClient.LetterCheck(Phone.Text) == false)
                    {
                        Phone.Clear();
                        throw new Exception("Please insert a correct '" + Phone.Name + "' !");
                    }

                    if (objNewClient.UnicodeCheck(Phone.Text,0) == false)
                    {
                        Phone.Clear();
                        throw new Exception("Please insert a correct '" + Phone.Name + "' !");
                    }
                   
                }

                objNewClient.Phone += Phone.Text;

                #endregion

                #region Username

                //objNewClient.NullCheck(Username);
                //objNewClient.UnicodeCheck(Username, 0);

                if (objNewClient.NullCheck(Username.Text) == false)
                {
                    Username.Clear();
                    throw new Exception("Please insert your '" + Username.Name + "' !");
                }

                if (objNewClient.UnicodeCheck(Username.Text, 0) == false)
                {
                    Username.Clear();
                    throw new Exception("Please insert a correct '" + Username.Name + "' !");
                }

                if (Username.Text.Contains("admin"))
                {
                    Username.Clear();
                    throw new Exception("Your Username cannot contain 'admin'!");
                }

                objNewClient.UserName += Username.Text;

                #endregion

                #region Password

                //objNewClient.NullCheck(Password);
                //objNewClient.PasswordRule(Password);

                if (objNewClient.NullCheck(Password.Text) == false)
                {
                    Password.Clear();
                    throw new Exception("Please insert your '" + Password.Name + "' !");
                }

                if ((objNewClient.PasswordRule1(Password.Text) == true) || (objNewClient.PasswordRule2(Password.Text) == true))
                {
                    Password.Clear();
                    throw new Exception("Your password must contain at least 1 uupercase " + Environment.NewLine + " and 1 special character!");
                }

                objNewClient.Password += Password.Text;

                #endregion
                
                if (checkBox1.Checked)
                {
                    //SQL Command
                    string _command = "INSERT INTO Customer.dbo.Customer (FirstName,LastName,Email,Phone,UserName,Password) VALUES('"
                                                                            + objNewClient.FName + "','"
                                                                            + objNewClient.LName + "','"
                                                                            + objNewClient.Email + "','"
                                                                            + objNewClient.Phone + "','"
                                                                            + objNewClient.UserName + "','"
                                                                            + objNewClient.Password + "')";

                    objNewClient.InsertReadUpdateData(_command);

                    //Using EntityFramework
                    /*using (CustomerEntities obj = new CustomerEntities())
                    {                       
                        Customer NewCustomer = new Customer();

                        NewCustomer.FirstName = objNewClient.FName;
                        NewCustomer.LastName = objNewClient.LName;
                        NewCustomer.Email = objNewClient.Email;
                        NewCustomer.Phone = objNewClient.Phone;
                        NewCustomer.UserName = objNewClient.UserName;
                        NewCustomer.Password = objNewClient.Password;
                        obj.Customers.Add(NewCustomer);
                        obj.SaveChanges();                        
                    }*/
                    
                    MessageBox.Show("You have succesfuly created an account!");
                    this.Close();
                    originalForm.enabledisable(1);
                }

                else
                {
                    Password.Clear();
                    throw new Exception("You didn't Agree the Terms of service!");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        //LinkLabels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://wikimediafoundation.org/wiki/Terms_of_Use");
            TermsLinkLabel.LinkVisited = true; //Shows that link was visited
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {        
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Wikipedia:Privacy_policy");
            PrivacyLinkLabel.LinkVisited = true; //Shows that link was visited

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

        #endregion
            
    }
}
