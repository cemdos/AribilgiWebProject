using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("Tag")]
    public partial class Tag:BaseModel
    {
        [Required]
        public string TagName { get; set; }

        public long TagCode { get; set; }
    }
}
