using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("Category")]
    public partial class Category : BaseModel
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        public int? ParentId { get; set; }

        public long? Tags { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
