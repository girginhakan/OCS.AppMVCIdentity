using OCS.BLL.Managers.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using OCS.ViewModel.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Concrete
{
    public class OrderItemManager : Manager<OrderItemDto, OrderItemViewModel, Order>
    {
        public OrderItemManager(Service<Order, OrderItemDto> service) : base(service)
        {
        }
    }
}
