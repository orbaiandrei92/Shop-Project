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
    public partial class Password : Form
    {

        #region Fields Region

        //Panel movement variables    
        private bool mouseDown;
        private Point lastLocation;
 
        LoginDesign originalForm;

        #endregion

        #region Constructor

        public Password(LoginDesign incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        #endregion

        #region Methods Region

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

        //Exit & Minimize Form
        private void ExitMinimize(object sender, EventArgs e)
        {
            Button sendingButton = (Button)sender;
            switch (sendingButton.Name)
            {
                case "ExitButton":
                    this.Close();
                    originalForm.enabledisable(1);
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }
       
        private void SubmitButtons(object sender, EventArgs e)
        {
            try
            {
                TheClasses.ForgotPassword objForgotPassword = new TheClasses.ForgotPassword();

                Button sendingButton = (Button)sender;
                switch (sendingButton.Name)
                {
                    case "Submit1Button":
                        string command1 = "SELECT Email FROM Customer.dbo.Customer WHERE Email ='" + "@2 " + textBox1.Text + "'";
                        objForgotPassword.RetrieveData(command1, 0);

                        if (objForgotPassword.EmailCheck.Contains(textBox1.Text))
                        {
                            Submit1Button.Visible = false;
                            Submit2Button.Visible = true;
                            ChangeLabel.Text = "Please enter your First Name:";
                            textBox1.Clear();
                        }
                        else
                        {
                            throw new Exception("Check again the email you've entered!");
                        }
                        break;
                    case "Submit2Button":
                        string command2 = "SELECT FirstName FROM Customer.dbo.Customer WHERE FirstName ='" + "@0 " + textBox1.Text + "'";
                        objForgotPassword.RetrieveData(command2, 1);

                        if (objForgotPassword.FirstNameCheck.Contains(textBox1.Text))
                        {
                            ChangeLabel.Text = "Enter your new password:";
                            textBox1.UseSystemPasswordChar = true;
                            ResetButton.Visible = true;
                            Submit2Button.Visible = false;
                            textBox1.Clear();
                        }
                        else
                        {
                            throw new Exception("Check again the First Name you've entered!");
                        }
                        break;
                    case "ResetButton":
                        if ((objForgotPassword.PasswordRule1(textBox1.Text) == true) || (objForgotPassword.PasswordRule2(textBox1.Text) == true))
                        {
                            textBox1.Clear();
                            throw new Exception("Your password must contain at least 1 uupercase " + Environment.NewLine + " and 1 special character!");
                        }

                        string command3 = "UPDATE Customer.dbo.Customer SET Password='" + "@5 " + textBox1.Text + "' WHERE Email='" + objForgotPassword.EmailCheck + "'";

                        objForgotPassword.InsertReadUpdateData(command3);                     
                        ChangeLabel.Text = "You have succesfully changed" + Environment.NewLine + "your password!";
                        ResetButton.Visible = false;
                        textBox1.Visible = false;
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #endregion

    }
}
