namespace Bucket.Models.tempModels
{
    public class UpdateProjectInput
    {
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public List<MediaInput> Media { get; set; }
        public List<string> Tags { get; set; }
    }
}
