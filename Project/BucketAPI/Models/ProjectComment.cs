namespace Bucket.Models
{
    public class ProjectComment
    {

        public string CommentContent { get; set; } = string.Empty;

        public string CommentedUsername { get; set; } = string.Empty;

        public DateTime? CommentedTime { get; set; }
    }
}
