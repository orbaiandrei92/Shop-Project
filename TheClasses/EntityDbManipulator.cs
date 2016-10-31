using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheClasses
{
    public abstract class EntityDbManipulator
    {

        public string _connectionString = "Data Source=DESKTOP-677BDBL;Initial Catalog=Customer;Integrated Security=True";

        public abstract void InsertReadUpdateData(string command);

    }
}
