using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.Models
{
    public class Engineers
    {
        public int EngineerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int Tel { get; set; }
        public int AddressID { get; set; }
    }
}
