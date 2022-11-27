using AribilgiWebProject.BLL.Interfaces;
using AribilgiWebProject.DAL;
using AribilgiWebProject.Model;
using System;
using System.Collections.Generic;

namespace AribilgiWebProject.BLL.Classes
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public BaseResponseModel<int> CreateOrder(Order order,List<OrderDetail> orderDetailList)
        {
            var response = new BaseResponseModel<int>();
            try
            {
                var orderResponse = UnitOfWork.Instance.AddData(order);
                foreach (var orderDetailItem in orderDetailList)
                {
                    orderDetailItem.OrderId = orderResponse.ID;
                    UnitOfWork.Instance.AddData(orderDetailItem);
                    var product = UnitOfWork.Instance.GetById<Product>(orderDetailItem.ProductId);
                    product.Stock -= orderDetailItem.Quantity;
                    UnitOfWork.Instance.UpdateData(product);
                }
            }
            catch (System.Exception ex)
            {
                response.ErrorMessage = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
