using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface EntityDbManipulator<T,T1>
    {
        string Create(T obj);
        string Create(T1 obj);

        T Retrieve(string key);

        void Update(T obj);

        void Delete(string key);

    }
}
