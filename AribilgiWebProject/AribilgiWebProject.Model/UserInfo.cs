using AribilgiWebProject.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("UserInfo")]
    public class UserInfo: BaseModel
    {
        public int UserId { get; set; }
        public string InvoiceAddress { get; set; }
        public string ShippedAddress { get; set; }
    }
}
