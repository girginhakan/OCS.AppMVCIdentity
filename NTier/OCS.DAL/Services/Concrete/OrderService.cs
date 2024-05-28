using OCS.DAL.Repositories.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Services.Concrete
{
    public class OrderService : Service<Order, OrderDto>
    {
        public OrderService(Repo<Order> repo) : base(repo)
        {
        }
    }
}
