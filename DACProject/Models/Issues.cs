using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DACProject.Models
{
    public class Issues
    {
        public int issueId { get; set; }
        public string issueName { get; set; }
        public string issueDescription { get; set; }

        public enum issueStatus {
			Active,
			InProgress,
			OnTrack,
			Delayed,
			InTesting,
			OnHold,
			Approved,
			Cancelled,
			Planning,
			Completed,
			Invoiced
		}
        public enum issuePriority { High, Medium, Low }
        public enum issueSeverity { Blocker, Critical, Major, Minor, Trivial }
        public string resolutionSummary { get; set; }

		public string createdBy { get; set; }
		public string modifiedBy { get; set; }

        public DateTime targetResolutionDate { get; set; }
		public DateTime createdOn { get; set; }
		public DateTime modifiedOn { get; set; }

		

    }
}
