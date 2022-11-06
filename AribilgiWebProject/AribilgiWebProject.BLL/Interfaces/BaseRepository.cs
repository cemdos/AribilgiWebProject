using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IBaseRepository<T> where T:BaseModel
    {
        BaseResponseModel<T> Add(T model);
        BaseResponseModel<T> Update(T model);
        BaseResponseModel<List<T>>  GetAll();
        BaseResponseModel<T> GetById(int id);
        BaseResponseModel<T> Remove(int id);

    }
}
