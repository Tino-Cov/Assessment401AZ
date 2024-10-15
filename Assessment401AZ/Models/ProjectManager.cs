using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.Models
{
    public class ProjectManager
    {                                                                 // Comment: Created the ProjectManager Class with its attributes and get set command //
        public int ManagerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dateofbirth { get; set; }

        public string Management { get; set; } 
        public int Tel { get; set; }
        public string EmailAddress { get; set; }


    }
}
