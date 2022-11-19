using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("District")]
    public class District : BaseModel
    {
        public string DistrictName { get; set; }
        public int CityId { get; set; }
    }
}
