using System;
using System.Collections.Generic;

namespace Mumos.Models
{
    public class Job
    {
        public Job()
        {
            this.Technologies = new HashSet<Technology>();
            this.JobUsers = new HashSet<JobUser>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Requirements { get; set; }

        public string Qualifications { get; set; }

        public Company Company { get; set; }

        public int CompanyId { get; set; }

        public DateTime? DateOfEntry { get; set; }

        public virtual ICollection<Technology> Technologies { get; set; }

        public virtual ICollection<JobUser> JobUsers { get; set; }
    }
}