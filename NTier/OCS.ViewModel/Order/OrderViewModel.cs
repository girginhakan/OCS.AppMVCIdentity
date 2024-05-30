using OCS.ViewModel.OrderItem;
using OCS.ViewModel.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.Order
{
    public class OrderViewModel : BaseViewModel
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public string OrderStatus { get; set; }
        public ICollection<OrderItemViewModel> OrderItemsViewModel { get; set; }
        public ICollection<PaymentViewModel> PaymentsViewModel { get; set; }

    }
}
