using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Common.Enums;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Exception;
using AribilgiWebProject.Model;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IUserRepository:IBaseRepository<User>
    {
        BaseResponseModel<User> Login(string UserName, string Password);
        BaseResponseModel<User> Register(string UserName, string Email, string Password);
        BaseResponseModel<UserInfo> SaveAdress(int UserId, string InvoiceAddress, string ShippedAdress);

    }
}
