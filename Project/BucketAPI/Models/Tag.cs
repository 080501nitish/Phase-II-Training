using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TagID { get; set; }

        [Required]
        public string? TagName { get; set; }


        [JsonIgnore]
        public virtual ICollection<ProjectTag> ProjectTags { get; set; }
    }
}
