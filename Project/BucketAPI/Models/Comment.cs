using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }

        
   
        public int? UserID { get; set; }

        
       
        public int? ProjectID { get; set; }

        [Required]
        public string? CommentContent { get; set; }

        [Required]
        [Timestamp]
        public DateTime? CommentedAt { get; set; }

        [ForeignKey("UserID")]
        [JsonIgnore]
        public virtual User? Users { get; set; }

        [ForeignKey("ProjectID")]
        [JsonIgnore]
        public virtual Project? Projects { get; set; }
    }
}
