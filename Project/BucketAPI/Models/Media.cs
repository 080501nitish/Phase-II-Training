using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class Media
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int MediaID { get; set; }

        public int? ProjectID { get; set; }

        [Required]
        public string? MediaURL { get; set; }

        [Required]
        public string? Caption { get; set; }

        [ForeignKey("ProjectID")]
        [JsonIgnore]
        [Required]
        public virtual Project? Projects { get; set; }


        //edited
       


    }
}
