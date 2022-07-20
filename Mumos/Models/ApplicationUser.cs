using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mumos.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.JobUsers = new HashSet<JobUser>();
            this.FeedBacks = new HashSet<FeedBack>();
        }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        public virtual ICollection<JobUser> JobUsers { get; set; }

        public virtual ICollection<FeedBack> FeedBacks { get; set; }

    }
}
