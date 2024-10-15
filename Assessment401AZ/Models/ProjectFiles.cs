using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.Models
{
    public class ProjectFiles : ProjectManager
    {                                                                    // Comment: Added The ProjectFiles Class along with its attributes and foreign key //
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

        public string ProjectAddress { get; set; }

        public int ManagerID { get; set; }

    }
}
