using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IUserRepository:IBaseRepository<User>
    {
        BaseResponseModel<User> Login(string UserName, string Password);
    }
}
