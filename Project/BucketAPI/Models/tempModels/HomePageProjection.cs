namespace Bucket.Models.tempModels
{
    public class HomePageProjection
    {
        public int ProjectID { get; set; }

        public string MediaURL { get; set; } = string.Empty;

        /*public ICollection<ProjectionMedia> Media { get; set; } = new List<ProjectionMedia>();*/


        public string ProjectTitle { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public int LikeCount { get; set; }
    }
}
