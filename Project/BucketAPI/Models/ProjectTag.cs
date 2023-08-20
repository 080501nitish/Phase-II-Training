using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Bucket.Models
{
    public class ProjectTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectTagID { get; set; }

       
      
        public int? ProjectID { get; set; }

     
        public int? TagID { get; set; }

        

        [ForeignKey("ProjectID")]
        [JsonIgnore]
        public virtual Project? Projects { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag? Tags { get; set; }

       

        //edited
        /*   public ICollection<Tag> Tags { get; set; }*/
    }

}

