using AribilgiWebProject.BLL.Classes;
using AribilgiWebProject.Model;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Interfaces
{
    public interface IOrderRepository:IBaseRepository<Order>
    {
        BaseResponseModel<int> CreateOrder(Order order, List<OrderDetail> orderDetailList);
    }
}
