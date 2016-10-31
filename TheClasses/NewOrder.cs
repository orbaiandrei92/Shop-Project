using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TheClasses
{
    public class NewOrder : EntityClientOrder
    {
        #region Fields region

        string _address, _city, _region, _country, _postalcode, _fax, _shipvia;

        #endregion

        #region Properties Region

        public string Address { get { return _address; } set { _address = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string Region { get { return _region; } set { _region = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public string PostalCode { get { return _postalcode; } set { _postalcode = value; } }
        public string Fax { get { return _fax; } set { _fax = value; } }
        public string ShipVia { get { return _shipvia; } set { _shipvia = value; } }

        #endregion

        public NewOrder()
        {
            //Avoiding Injection
            _address = "@0 ";
            _city = "@1 ";
            _region = "@2 ";
            _country = "@3 ";
            _postalcode = "@4 +";
            _fax = "@5 ";
            _shipvia = "@6 ";
           
        }

        #region Methods Region

        public override bool NumberCheck(string value)
        {
            for (int i = 0; i < _num.Length; i++)
                if ((value).Contains(_num[i])) return false;

            return true;
        }

        public override bool NullCheck(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            return true;
        }

        public override bool UnicodeCheck(string value, int option)
        {
            for (int i = option; i < _info.Length; i++)
                if ((value).Contains(_info[i])) return false;

            return true;
        }

        //Letter check
        public override bool LetterCheck(string value)
        {

            foreach (string i in _letters)
                if ((value).Contains(i)) return false;

            return true;

        }

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
