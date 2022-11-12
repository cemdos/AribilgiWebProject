using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AribilgiProject.UI.ViewModel
{
    public class BaseResponseViewModel<TModel,TViewModel>:BaseResponseModel<TModel> 
        where TModel : BaseModel
        where TViewModel : BaseViewModel<TModel>,new ()
    {
        public TViewModel ResponseViewModel { get; set; }
        public List<TViewModel> ResponseViewModelList { get; set; }

        public BaseResponseViewModel(List<TModel> tModelList)
        {
            foreach (var item in tModelList)
            {
                var viewModel = new TViewModel();
            }
        }
    }
}