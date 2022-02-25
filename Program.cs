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
            AddressBookModel model1 = new AddressBookModel
            {
                firstName = "rohit",
                lastName = "jadhav",
                address = "Pu-154",
                city = "pune",
                state = "mharashtra",
                zip = "425001",
                mobileNo = "4567891230",
                email = "rohit665@gmail.com"
            };
            AddressBookModel model2 = new AddressBookModel
            {
                firstName = "ketan",
                lastName = "shinde",
                address = "Pu-154",
                city = "nashik",
                state = "mharashtra",
                zip = "425001",
                mobileNo = "4567891230",
                email ="ketan15@gmail.com"
                };

           DBHandler database = new DBHandler();
          //  database.Insert(model);
          //  database.Update(model, "rohit");
         //   database.Delete("rohit");
           // database.SelectByCityORState("pune");
          //  database.SelectCountByCountryORState();
         //   database.SortByCityORState("pune");
            //    database.AddMultpleContact(model1,model2);
           // database.AddBookName("Book1");
            database.FileWriter();

        }
    }
}