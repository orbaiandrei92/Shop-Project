using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public abstract class EntityClientOrder : EntityDbManipulator
    {

        #region Field Region

        //protected string _connectionString = "Data Source=DESKTOP-677BDBL;Initial Catalog=Customer;Integrated Security=True";

        public string[] _num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public string[] _info = { " ", "-", ".", ",", "?", ">", "<", "'",
                                  ":", ";", "|", "]", "[", "}", "{", "=",
                                  "+", "_", "/", ")", "(", "*", "&", "^",
                                  "%", "$", "#", "@", "!", "`", "~"};

        //public char[] _check = { '.', ',', ' ', '-' };

        public string[] _letters = {"a", "b", "c", "d", "e", "f", "g",
                                    "h", "i", "j", "k", "l", "m", "n",
                                    "o", "p", "q", "r", "s", "t", "u",
                                    "v", "w", "x", "y", "z"};

        #endregion

        #region Methods Region

        public abstract bool NumberCheck(string value);

        public abstract bool UnicodeCheck(string value, int option);

        public abstract bool NullCheck(string value);

        public abstract bool LetterCheck(string value);

        //public abstract void InsertReadUpdateData(string command);

        #endregion

    }
}
