using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required]
        
        public string? UserName { get; set; } 

        [Required]
        public string? UserEmail { get; set; }

        [Required]
        public string? UserPassword { get; set; }

       
        public string? UserPrfilePicture { get; set; }

        public string? UserBio { get; set;}

        [JsonIgnore]
        public virtual ICollection<Project> Projects { get; set; }
        [JsonIgnore]
        public virtual ICollection<Comment> Comments { get; set; }
        [JsonIgnore]
        public virtual ICollection<Like> Likes { get; set; } 

    }
}
