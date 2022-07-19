namespace Mumos.Models
{
    public class FeedBack
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Company Company { get; set; }

        public int CompanyId { get; set; }

        public Comment Comment { get; set; }

        public int CommentId { get; set; }
    }
}
