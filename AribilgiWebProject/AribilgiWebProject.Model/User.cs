using AribilgiWebProject.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AribilgiWebProject.Model
{
    [Table("User")]
    public class User: BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public RolEnum Rol { get; set; }
    }
}
