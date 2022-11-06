using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Linq;

namespace AribilgiWebProject.BLL.Classes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public BaseResponseModel<User> Login(string UserName, string Password)
        {
            BaseResponseModel<User> responseModel = new BaseResponseModel<User>();
            try
            {
                var User = UnitOfWork.GetAll<User>().Where(_ => _.UserName == UserName &&
                                                   _.Password == Password).FirstOrDefault();
                if (User == null)
                    throw new Exception("Kullanıcı adı yada şifre yanlış");

                responseModel.ResponseModel = User;
            }
            catch (Exception ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.IsSuccess = false;
            }
            return responseModel;
        }
    }
}
