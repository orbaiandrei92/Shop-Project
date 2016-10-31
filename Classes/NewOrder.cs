using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
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

        public override void NumberCheck(TextBox value)
        {
            for (int i = 0; i < _info.Length; i++)
            {
                if ((value.Text).Contains(_info[i]))
                {
                    throw new Exception("Please insert a correct '" + value.Name + "' !");
                }
            }
        }

        public override void NullCheck(TextBox value)
        {
            if (string.IsNullOrWhiteSpace(value.Text))
            {
                throw new Exception("Please insert your '" + value.Name + "' !");
            }
        }

        public override void UnicodeCheck(TextBox value, int option)
        {
            for (int i = option; i < _info.Length; i++)
            {
                if ((value.Text).Contains(_info[i]))
                {
                    throw new Exception("Please insert a correct '" + value.Name + "' !");
                }
            }
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
