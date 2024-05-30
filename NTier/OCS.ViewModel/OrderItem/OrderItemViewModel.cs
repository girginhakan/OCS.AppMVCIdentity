using OCS.ViewModel.Order;
using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.OrderItem
{
    public class OrderItemViewModel : BaseViewModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }


        public OrderViewModel OrderViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
    }
}
