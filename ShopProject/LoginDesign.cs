using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopProject
{
    public partial class LoginDesign : Form
    {

        #region Fields Region

        bool mouseDown;
        Point lastLocation;

        static string passwordcheck, usernamecheck, lastnamecheck;
        static int customeridcheck;

        string command;
        string ConnectionString = "Data Source=DESKTOP-677BDBL;Initial Catalog=Customer;Integrated Security=True";

        #endregion

        #region Constructor

        public LoginDesign()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties Region

        //Using the UserName for late processing!
        public static string UserName { get { return usernamecheck; } }

        //Using the CustomerId for late processing!
        public static int CustomerIdCheck { get { return customeridcheck; } }

        #endregion

        #region Methods Region

        //SignIn
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                command = "SELECT UserName, Password, LastName, CustomerId FROM Customer.dbo.Customer WHERE UserName='" + "@4 " + textBox1.Text + "' AND Password='" + "@5 " + textBox2.Text + "'";
                SelectData(command);

                if (usernamecheck.Contains(textBox1.Text) && passwordcheck.Contains(textBox2.Text))
                {
                    this.Visible = false;
                    Shop objShop = new Shop();
                    objShop.Show();
                }
                else throw new Exception("Please check again your 'User Name' and 'Password'!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //Selecting data from SQL Server
        public void SelectData(string value)
        {
            //Open connection
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();

            //Fire command
            SqlCommand objCommand = new SqlCommand(value, objConnection);

            SqlDataReader reader = objCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usernamecheck = reader["UserName"].ToString();
                    passwordcheck = reader["Password"].ToString();
                    lastnamecheck = reader["LastName"].ToString();
                    customeridcheck = Convert.ToInt32(reader["CustomerId"]);
                }
            }

            {
                Console.WriteLine("No rows found.");
            }

            reader.Close();

            //Close connection
            objConnection.Close();
        }

        //SignUp
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {           
            SignUpDesign newaccount = new SignUpDesign(this);
            newaccount.Show();
            enabledisable(0);            
        }

        //Forgot password Form
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password objPassword = new Password(this);
            objPassword.Show();
            enabledisable(0);
        }

        //Enable-Disable tools
        internal void enabledisable(int EnableOrDisable)
        {
            switch (EnableOrDisable)
            {
                case 0:
                    SignInButton.Enabled = false;
                    SignUpLinkLabel.Enabled = false;
                    ForgotPassLinkLabel.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    ExitButton.Enabled = false;
                    MinimizeButton.Enabled = false;
                    break;
                case 1:
                    SignInButton.Enabled = true;
                    SignUpLinkLabel.Enabled = true;
                    ForgotPassLinkLabel.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    ExitButton.Enabled = true;
                    MinimizeButton.Enabled = true;
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
                    Application.Exit();
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        #endregion

    }
}
