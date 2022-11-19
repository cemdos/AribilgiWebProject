using AribilgiWebProject.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("City")]
    public class City: BaseModel
    {
        public string CityName { get; set; }
    }
}
