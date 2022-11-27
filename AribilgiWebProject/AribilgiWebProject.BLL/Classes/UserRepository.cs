using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.Common.Enums;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Exception;
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
                var User = UnitOfWork.Instance.GetAll<User>().Where(_ => _.UserName == UserName &&
                                                   _.Password == Password).FirstOrDefault();
                if (User == null)
                    throw new ExceptionUserNamePassword();

                responseModel.ResponseModel = User;
            }
            catch(ExceptionUserNamePassword ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.IsSuccess = false;
                responseModel.ResponseCode = ResponseCode.ValidationErrors;
            }
            catch (System.Exception ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.IsSuccess = false;
                responseModel.ResponseCode = ResponseCode.OtherErrors;
            }
            return responseModel;
        }

        public BaseResponseModel<User> Register(string UserName, string Email, string Password)
        {
            BaseResponseModel<User> responseModel = new BaseResponseModel<User>();
            try
            {
                var FindedUser = UnitOfWork.Instance.GetAll<User>().Find(x => x.Email == Email);
                if (FindedUser != null)
                    throw new ExceptionRepeatedUser();
                var newUser = new User
                {
                    Email = Email,
                    Password = Password,
                    Rol = RolEnum.Customer,
                    UserName = UserName
                };

                var createdUser = UnitOfWork.Instance.AddData(newUser);
                responseModel.ResponseModel = createdUser;
            }
            catch (ExceptionRepeatedUser ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.ResponseCode = ResponseCode.ValidationErrors;
                responseModel.IsSuccess = false;
            }
            catch (System.Exception ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.ResponseCode = ResponseCode.OtherErrors;
                responseModel.IsSuccess = false;
            }
            return responseModel;
        }

        public BaseResponseModel<UserInfo> SaveAdress(int UserId,string InvoiceAddress,string ShippedAdress)
        {
            BaseResponseModel<UserInfo> responseModel = new BaseResponseModel<UserInfo>();
            try
            {
                var FindedUserInfo = UnitOfWork.Instance.GetAll<UserInfo>().Find(x => x.UserId == UserId);
                if (FindedUserInfo != null)
                {
                    FindedUserInfo.InvoiceAddress = InvoiceAddress;
                    FindedUserInfo.ShippedAddress = ShippedAdress;
                    responseModel.ResponseModel = UnitOfWork.Instance.UpdateData(FindedUserInfo);
                    return responseModel;
                }

                var newUserInfo = new UserInfo
                {
                    UserId = UserId,
                    ShippedAddress=ShippedAdress,
                    InvoiceAddress=InvoiceAddress
                };

                var createdUser = UnitOfWork.Instance.AddData(newUserInfo);
                responseModel.ResponseModel = createdUser;
            }
            catch (System.Exception ex)
            {
                responseModel.ErrorMessage = ex.Message;
                responseModel.ResponseCode = ResponseCode.OtherErrors;
                responseModel.IsSuccess = false;
            }
            return responseModel;
        }
    }
}
