using OCS.BLL.Managers.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using OCS.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Concrete
{
    public class OrderManager : Manager<OrderDto, OrderViewModel, Order>
    {
        public OrderManager(Service<Order, OrderDto> service) : base(service)
        {
        }
    }
}
