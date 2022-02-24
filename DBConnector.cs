using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    public abstract class DBConnector
    {
        public SqlConnection GetDBConnection()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True");
        }
        public abstract int Insert(AddressBookModel model);
    }
}
