using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DTO
{
    public class OrderDto:BaseDto
    {
        //public int AppUserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public string OrderStatus { get; set; }


        //public AppUser AppUser { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
