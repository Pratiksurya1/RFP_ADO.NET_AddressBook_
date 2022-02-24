using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    public class AddressBookModel
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String mobileNo { get; set; }
        public String email { get; set; }
    }
}
