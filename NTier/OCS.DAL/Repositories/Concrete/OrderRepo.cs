using OCS.DAL.Data;
using OCS.DAL.Repositories.Abstract;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Repositories.Concrete
{
    public class OrderRepo : Repo<Order>
    {
        public OrderRepo(OCSDbContext dbContext) : base(dbContext)
        {
        }
    }
}
