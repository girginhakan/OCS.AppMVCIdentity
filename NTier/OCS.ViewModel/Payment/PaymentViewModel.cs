using OCS.ViewModel.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.Payment
{
    public class PaymentViewModel : BaseViewModel
    {
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }


        public OrderViewModel OrderViewModel { get; set; }
    }
}
