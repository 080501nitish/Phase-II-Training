using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [Required]
        public string? ProjectTitle { get; set; }

        [Required]
        public string? ProjectDescription { get; set; }
        
        [Required]
        public DateTime? ProjectCreatedAt { get; set; }

        /*
                [Newtonsoft.Json.JsonProperty("dateOfBirth")]
            private string ProjectCreatedAt { get; set; }

            [JsonIgnore]
            public DateTime? dateOfBirth
            {
                get { return DateTime.Parse(ProjectCreatedAt, new CultureInfo("en-US")); }
            }*/

        public int? UserID{ get; set; }

        [ForeignKey("UserID")]
        [JsonIgnore]
        [Required]
        public User? Users { get; set; }

        [JsonIgnore]
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<Media> Media { get; set; } = new List<Media>();

        [JsonIgnore]
        public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

        public virtual ICollection<ProjectTag> ProjectTags { get; set; } = new List<ProjectTag>();
    }
}
