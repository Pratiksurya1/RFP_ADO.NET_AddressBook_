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
        public abstract void Insert(AddressBookModel model);
        public abstract void Update(AddressBookModel model, String position);
        public abstract void Delete(string position);
        public abstract void SelectByCityORState(String location);
        public abstract void SelectCountByCountryORState();
        public abstract void SortByCityORState(string location);
        public abstract void AddMultpleContact(params AddressBookModel[] models);
    }
}
