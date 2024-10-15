using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment401AZ.Models
{
    public class ProjectAssignment : ProjectFiles 
    {
        public int ProjectName { get; set; }

        public string ProjectManagerList { get; set; }
 
        public int ProjectID { get; set; }

        public string ProjectAddress { get; set; }


    }
}
