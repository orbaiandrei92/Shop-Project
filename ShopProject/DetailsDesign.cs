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
    public partial class DetailsDesign : Form
    {
        #region Fields Region

        //Panel movement variables    
        private bool mouseDown;
        private Point lastLocation;

        string _connectionString = "Data Source=DESKTOP-677BDBL;Initial Catalog=Customer;Integrated Security=True";

        Shop originalForm;

        #endregion

        #region Constructor

        public DetailsDesign(Shop incomingForm)
        {
            originalForm = incomingForm;

            InitializeComponent();
        }

        #endregion

        #region Methods Region

        //Admin view buttons
        private void ViewButtons(object sender, EventArgs e)
        {
            
            Button sendingButton = (Button)sender;
            switch (sendingButton.Name)
            {               
                case "OrdersButton":
                    string command2 = "SELECT LastName, TotalItems, TotalPrice, ShipVia FROM Customer.dbo.Customer JOIN Customer.dbo.Orders ON Customer.CustomerId = Orders.CustomerId";

                    ViewData(command2);
                    break;
                case "AccountsButton":
                    string command1 = "SELECT CustomerId, LastName, UserName, Email FROM Customer.dbo.Customer";

                    ViewData(command1);
                    break;
            }
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

        //Exit & Minimize Form
        private void ExitMinimize(object sender, EventArgs e)
        {
            Button sendingButton = (Button)sender;
            switch (sendingButton.Name)
            {
                case "ExitButton":
                    this.Close();
                    originalForm.enabledisable(4, 1);
                    break;
                case "MinimizeButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        //Getting data from SQL
        public void ViewData(string commandString)
        {
            //Open connection
            SqlConnection objConnection = new SqlConnection(_connectionString);
            objConnection.Open();

            //Fire command
            SqlCommand objCommand = new SqlCommand(commandString, objConnection);
            DataSet objDataSet = new DataSet();

            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);

            //Bind data to UI
            dataGridView1.DataSource = objDataSet.Tables[0];

            //Close connection
            objConnection.Close();
        }

        #endregion

    }
}
