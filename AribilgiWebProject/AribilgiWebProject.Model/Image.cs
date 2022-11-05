using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("Image")]
    public partial class Image:BaseModel
    {
        [Required]
        public string TableName { get; set; }

        public int TableReferance { get; set; }

        [Required]
        public string PicUrl { get; set; }
    }
}
