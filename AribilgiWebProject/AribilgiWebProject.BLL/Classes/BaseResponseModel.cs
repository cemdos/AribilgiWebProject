namespace AribilgiWebProject.BLL.Classes
{
    public class BaseResponseModel<T> 
    {
        public bool IsSuccess { get; set; }
        public string ResponseMessage { get; set; }
        public string ErrorMessage { get; set; }
        public T ResponseModel { get; set; }
        public BaseResponseModel()
        {
            IsSuccess = true;
            ResponseMessage = string.Empty;
            ErrorMessage = string.Empty;
        }
    }
}
