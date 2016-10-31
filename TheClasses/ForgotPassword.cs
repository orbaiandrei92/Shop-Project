using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TheClasses
{
    public class ForgotPassword : EntityDbManipulator
    {

        #region Field Region

        static string _emailcheck; 
        string _firstnamecheck;

        public string[] _letters = {"a", "b", "c", "d", "e", "f", "g",
                                    "h", "i", "j", "k", "l", "m", "n",
                                    "o", "p", "q", "r", "s", "t", "u",
                                    "v", "w", "x", "y", "z"};

        public string[] _info = { " ", "-", ".", ",", "?", ">", "<", "'",
                                  ":", ";", "|", "]", "[", "}", "{", "=",
                                  "+", "_", "/", ")", "(", "*", "&", "^",
                                  "%", "$", "#", "@", "!", "`", "~"};

        #endregion

        #region Properties Region

        public string EmailCheck { get { return _emailcheck; } set { _emailcheck = value; } }
        public string FirstNameCheck { get { return _firstnamecheck; } set { _firstnamecheck = value; } }

        #endregion

        #region Constructor

        public ForgotPassword()
        {

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

        public override void InsertReadUpdateData(string commandString)
        {
            //Open connection
            SqlConnection objConnection = new SqlConnection(_connectionString);
            objConnection.Open();

            //Fire command
            DataSet objDataSet = new DataSet();

            SqlDataAdapter objDataAdapter = new SqlDataAdapter(commandString, objConnection);
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(objDataAdapter);
            objDataAdapter.Fill(objDataSet);

            //Close connection
            objConnection.Close();
        }

        //Retrieve data from SQL server
        public void RetrieveData(string commandvalue, int optioncase)
        {
            //Open connection
            SqlConnection objConnection = new SqlConnection(_connectionString);
            objConnection.Open();

            //Fire command
            SqlCommand objCommand = new SqlCommand(commandvalue, objConnection);

            SqlDataReader reader = objCommand.ExecuteReader(); 

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    switch (optioncase)
                    {
                        case 0:
                            {
                                _emailcheck = reader["Email"].ToString();
                                break;
                            }
                        case 1:
                            {
                                _firstnamecheck = reader["FirstName"].ToString();
                                break;
                            }
                        default: return;
                    }
                }
            }

            {
                Console.WriteLine("No rows found.");
            }

            reader.Close();

            //Close connection
            objConnection.Close();
        }

        #endregion

    }
}
