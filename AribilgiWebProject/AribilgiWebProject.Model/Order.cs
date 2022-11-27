using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("Order")]
    public partial class Order:BaseModel
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int? DistrictId { get; set; }
        public double ShippedPrice { get; set; }
    }
}
