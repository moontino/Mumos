using System.ComponentModel.DataAnnotations;

namespace Mumos.Models
{
    public class JobUser
    {
        public int Id { get; set; }

        public Job Job { get; set; }

        public int JobId { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
