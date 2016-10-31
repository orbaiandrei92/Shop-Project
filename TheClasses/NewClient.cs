using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheClasses
{
    public class NewClient : EntityClientOrder
    {
        #region Fields Region

        string _fname, _lname, _email, _username, _password, _phone;      

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
        public bool PasswordRule1(string value)
        {
            foreach (string val in _info)           
                if (value.Contains(val)) return false;
              
            return true;          
        }
        public bool PasswordRule2(string value)
        {         
            foreach (string val in _letters)
                if (value.Contains(val.ToUpper())) return false;

            return true;
        }
        
        //Null check
        public override bool NullCheck(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            
            return true;
        }

        //Unicode check
        public override bool UnicodeCheck(string value, int option)
        {
            for (int i = option; i < _info.Length; i++)
                if ((value).Contains(_info[i])) return false;

            return true;
        }

        //Number check
        public override bool NumberCheck(string value)
        {
            for (int i = 0; i < _num.Length; i++)
                if ((value).Contains(_num[i])) return false;

            return true;
        }

        //Email check
        public bool EmailCheck(string value)
        {
            
            foreach (string element in EmailList)           
                if ((value).Contains(element)) return false;
            
            /*EmailList.ForEach(delegate (string s) {
                if (value.Contains(s)) x = true;
            });*/ //Faster method ??   

            return true;

        }

        //Letter check
        public override bool LetterCheck(string value)
        {

            foreach (string i in _letters)            
                if ((value).Contains(i)) return false;

            return true;

        }

        //Capitalize first letter
        /*public string CapitalizeFirstLetter(string value)
        {
            if (value.Length == 1) return value = value.ToUpper();
            else return value = value.Remove(1).ToUpper() + value.Substring(1);
        }*/
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
