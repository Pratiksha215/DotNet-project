using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DACProject.Models
{
    public class Projects
    { 
        [Key]
        public int projectId { get; set; }
        public string projectName { get; set; }
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public DateTime startDate { get; set; }
        public DateTime targetEndDate { get; set; }
        public DateTime actualEndDate { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }

    }
}
