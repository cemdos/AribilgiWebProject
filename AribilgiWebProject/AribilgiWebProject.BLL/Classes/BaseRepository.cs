using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Classes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public BaseResponseModel<T> Add(T model)
        {
            BaseResponseModel<T> responseModel = new BaseResponseModel<T>();
            try
            {
                responseModel.ResponseModel = UnitOfWork.AddData(model);
                responseModel.ResponseMessage = "Command completed Successful";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.ErrorMessage = ex.Message;
            }
            return responseModel;
        }

        public BaseResponseModel<List<T>> GetAll()
        {
            BaseResponseModel<List<T>> responseModel = new BaseResponseModel<List<T>>();
            try
            {
                responseModel.ResponseModel = UnitOfWork.GetAll<T>();
                responseModel.ResponseMessage = "Command completed Successful";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.ErrorMessage = ex.Message;
            }
            return responseModel;
        }

        public BaseResponseModel<T> GetById(int id)
        {
            BaseResponseModel<T> responseModel = new BaseResponseModel<T>();
            try
            {
                responseModel.ResponseModel = UnitOfWork.GetById<T>(id);
                responseModel.ResponseMessage = "Command completed Successful";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.ErrorMessage = ex.Message;
            }
            return responseModel;
        }

        public BaseResponseModel<T> Remove(int id)
        {
            BaseResponseModel<T> responseModel = new BaseResponseModel<T>();
            try
            {
                responseModel.ResponseModel = UnitOfWork.RemoveData<T>(id);
                responseModel.ResponseMessage = "Command completed Successful";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.ErrorMessage = ex.Message;
            }
            return responseModel;
        }

        public BaseResponseModel<T> Update(T model)
        {
            BaseResponseModel<T> responseModel = new BaseResponseModel<T>();
            try
            {
                responseModel.ResponseModel = UnitOfWork.UpdateData(model);
                responseModel.ResponseMessage = "Command completed Successful";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.ErrorMessage = ex.Message;
            }
            return responseModel;
        }
    }
}
