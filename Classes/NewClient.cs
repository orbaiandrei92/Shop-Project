using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes
{
    public class NewClient : EntityClientOrder
    {
        #region Fields Region

        string _fname, _lname, _email, _username, _password, _phone;

        string[] _upper = { "A", "B", "C", "D", "E", "F", "G", "H",
                          "I", "J", "K", "L", "M", "N", "O", "P",
                          "Q", "R", "S", "T", "U", "V", "W", "X",
                          "Y", "Z"};

        private List<string> EmailList = new List<string>();

        #endregion

        #region Properties Region

        public string FName { get { return _fname; } set { _fname = value; } }
        public string LName { get { return _lname; } set { _lname = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        #endregion

        #region Constructor Region

        public NewClient()
        {

            //Avoiding Injection
            _fname = "@0 ";
            _lname = "@1 ";
            _email = "@2 ";
            _phone = "@3 +40";
            _username = "@4 ";
            _password = "@5 ";

            //List of valid emails
            EmailList.Add("@yahoo.com");
            EmailList.Add("@gmail.com");

        }

        #endregion

        #region Methods Region       

        //Password containing 1 uppercase and 1 special char.
        public void PasswordRule(TextBox value)
        {
            bool x = false;

            foreach (string val in _info)
            {
                if (value.Text.Contains(val)) x = true;
            }

            foreach (string val in _upper)
            {
                if (value.Text.Contains(val)) x = true;
            }

            if (x == false)
            {
                value.Clear();
                throw new Exception("Your password must contain at least 1 uupercase " + Environment.NewLine + " and 1 special character!");
            }
        }

        //Capitalize first letter
        public string CapitalizeFirstLetter(string value)
        {
            if (value.Length == 1) return value = value.ToUpper();
            else return value = value.Remove(1).ToUpper() + value.Substring(1);
        }

        //Null check
        public override void NullCheck(TextBox value)
        {
            if (string.IsNullOrWhiteSpace(value.Text))
            {
                value.Clear();
                throw new Exception("Please insert your '" + value.Name + "' !");
            }
        }

        //Unicode check
        public override void UnicodeCheck(TextBox value, int option)
        {
            for (int i = option; i < _info.Length; i++)
            {
                if ((value.Text).Contains(_info[i]))
                {
                    value.Clear();
                    throw new Exception("Please insert a correct '" + value.Name + "' !");
                }
            }
        }

        //Number check
        public override void NumberCheck(TextBox value)
        {
            for (int i = 0; i < _num.Length; i++)
            {
                if ((value.Text).Contains(_num[i]))
                {
                    value.Clear();
                    throw new Exception("Please insert a correct '" + value.Name + "' !");
                }
            }
        }

        //Email check
        public void EmailCheck(TextBox value)
        {
            bool x = false;

            /*foreach (string element in EmailList)
            {
                if (x = ((value.Text).Contains(element))) return;
            }*/

            EmailList.ForEach(delegate (string s) {
                if (value.Text.Contains(s)) x = true;
            }); //Faster method ??   

            if (x == false)
            {
                value.Clear();
                throw new Exception("Please insert a correct Email! (...@yahoo.com/@gmail.com)");
            }
        }

        //Phone check
        public void PhoneCheck(TextBox value)
        {
            bool x = false;

            foreach (string i in _num)
            {
                if ((value.Text).Contains(i)) x = true;
            }

            if (x == false)
            {
                value.Clear();
                throw new Exception("Please insert a correct '" + value.Name + "' !");
            }
        }

        //Capitalize after space & -
        /*public void CapitalizeAfter(TextBox value, int option)
        {
            for (int i = option; i < _check.Length; i++)
                if (value.Text.Contains(_check[i]))
                {
                    int x = value.Text.IndexOf(_check[i]);
                    string y = value.Text.Substring(x);
                    CapitalizeFirstLetter(y);
                    value.Text = value.Text.Remove(x+1) + y;
                    int h = 8;
                }
            //value.Text.ToTitleCase();
        }*/

        #endregion

        #region Insert Data to SQL

        public override void InsertReadUpdateData(string commandString)
        {
            //Open connection
            SqlConnection objConnection = new SqlConnection(_connectionString);
            objConnection.Open();

            //Fire command
            SqlCommand objCommand = new SqlCommand(commandString, objConnection);
            objCommand.ExecuteNonQuery();

            //Close connection
            objConnection.Close();
        }


        #endregion

    }
}
