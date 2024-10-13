using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.Models
{
    public class Address
    {
        private int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }

    }
}
