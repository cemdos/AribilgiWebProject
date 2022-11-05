using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("Product")]
    public partial class Product:BaseModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public double UnitPrice { get; set; }

        public short? Discount { get; set; }

        public short? Rate { get; set; }

        public long Color { get; set; }

        public long? Tags { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
