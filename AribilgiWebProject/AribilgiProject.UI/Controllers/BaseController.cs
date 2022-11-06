using Newtonsoft.Json;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected string JsonDataConvert<T>(T model)
        {
            return JsonConvert.SerializeObject(model);
        }
    }
}