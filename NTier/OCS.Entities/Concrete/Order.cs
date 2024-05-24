using OCS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int AppUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public string OrderStatus { get; set; }


        public AppUser AppUser { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
