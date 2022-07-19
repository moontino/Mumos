using System.Collections.Generic;

namespace Mumos.Models
{
    public class Location
    {
        public Location()
        {
            this.Companies = new HashSet<Company>();
        }
        public int Id { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Company>  Companies { get; set; }

    }
}