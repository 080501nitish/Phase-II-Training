namespace Bucket.Models.tempModels
{
    public class ProjectInput
    {
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public List<MediaInput> Media { get; set; }
        public List<string> Tags { get; set; }
        public int UserID { get; set; }
    }
    public class MediaInput
    {
        public string MediaURL { get; set; }
        public string Caption { get; set; }
    }
}
