using System.Collections.Generic;

namespace Mumos.Models
{
    public class Company
    {
        public Company()
        {
            this.Technologies = new HashSet<Technology>();
            this.Jobs= new HashSet<Job>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Sector Sector { get; set; }

        public int SectorId { get; set; }

        public string TypeOfWork { get; set; }

        public int NumberOfEmployees { get; set; }

        public string Info { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Technology> Technologies { get; set; }
    }
}