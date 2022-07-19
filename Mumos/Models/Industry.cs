using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mumos.Models
{
    public class Industry
    {
        public Industry()
        {
            this.Jobs = new HashSet<Job>();
            this.Companies = new HashSet<Company>();
            this.Technologies = new HashSet<Technology>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Technology> Technologies { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
