using AribilgiProject.UI.ViewModel;
using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AribilgiProject.UI.Controllers
{
    public class OrderController : BaseController
    {
        private OrderRepository orderRepository;
        public OrderController()
        {
            orderRepository = new OrderRepository();
        }

        [HttpGet]
        public string CreateOrder()
        {
            string OrderString = Request.Params["Order"];
            string OrderDetailString = Request.Params["OrderDetail"];
            var Order = JsonConvert.DeserializeObject<Order>(OrderString);
            var OrderDetailList = JsonConvert.DeserializeObject<List<OrderDetail>>(OrderDetailString);
            var result = orderRepository.CreateOrder(Order, OrderDetailList);
            return JsonDataConvert(result);
        }
    }
}