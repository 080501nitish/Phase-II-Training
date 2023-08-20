namespace Bucket.Models.tempModels
{

    public class ProjectDetails
    {

        public string ProjectTitle { get; set; } = string.Empty;

        public string ProjectDescription { get; set; } = string.Empty;

        public DateTime ProjectCreatedAt { get; set; }

        public ICollection<ProjectionMedia> Media { get; set; } = new List<ProjectionMedia>();

        public int? LikeCount { get; set; }
        public ICollection<ProjectComment> Comments { get; set; } = new List<ProjectComment>();

        public ICollection<string> Tags { get; set; } = new List<string>();

        public string Username { get; set; } = string.Empty;
    }
}
