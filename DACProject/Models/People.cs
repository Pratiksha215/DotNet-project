using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DACProject.Models
{
    public class People
    {
        public int personId { get; set; }
        public string personName { get; set; }
        public string password { get; set; }
        public string personEmail { get; set; }

        public enum role { ProjectManager , Developer , TestEngineer }
        public int assignedProjects { get; set; }

        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }

    }
}
