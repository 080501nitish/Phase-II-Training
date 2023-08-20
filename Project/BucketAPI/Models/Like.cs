using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class Like
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LikeID { get; set; }

       
     
        public int? UserID { get; set; }

  
    
        public int? ProjectID { get; set; }

        [ForeignKey("UserID")]
        [JsonIgnore]
        public virtual User? Users { get; set; }

        [ForeignKey("ProjectID")]
        [JsonIgnore]
        public virtual Project? Projects { get; set; }

    }
}
