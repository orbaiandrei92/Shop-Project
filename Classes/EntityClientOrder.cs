using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class EntityClientOrder 
    {

        #region Field Region

        protected string _connectionString = "Data Source=DESKTOP-677BDBL;Initial Catalog=Customer;Integrated Security=True";

        public string[] _num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public string[] _info = { " ", "-", ".", ",", "?", ">", "<", "'",
                                  ":", ";", "|", "]", "[", "}", "{", "=",
                                  "+", "_", "/", ")", "(", "*", "&", "^",
                                  "%", "$", "#", "@", "!", "`", "~"};

        public char[] _check = { '.', ',', ' ', '-' };

        #endregion

        #region Methods Region

        public abstract void NumberCheck(TextBox value);

        public abstract void UnicodeCheck(TextBox value, int option);

        public abstract void NullCheck(TextBox value);

        public abstract void InsertReadUpdateData(string command);

        #endregion

    }
}
