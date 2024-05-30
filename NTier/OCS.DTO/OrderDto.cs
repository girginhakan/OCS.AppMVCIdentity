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
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public string OrderStatus { get; set; }


        public ICollection<OrderItemDto> OrderItemsDto { get; set; }
        public ICollection<PaymentDto> PaymentsDto { get; set; }
    }
}
