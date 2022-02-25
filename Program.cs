using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            AddressBookModel model = new AddressBookModel();
            model.firstName = "rohit";
            model.lastName = "jadhav";
            model.address = "Pu-154";
            model.city = "pune";
            model.state = "mharashtra";
            model.zip = "425001";
            model.mobileNo = "4567891230";
            model.email = "rohit665@gmail.com";

            DBConnector database = new DBHandler();
          //  database.Insert(model);
          //  database.Update(model, "rohit");
         //   database.Delete("'rohit'");
           // database.SelectByCityORState("'pune'");
            database.SelectCountByCountryORState();

        }
    }
}