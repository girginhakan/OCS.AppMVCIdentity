using OCS.BLL.Managers.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using OCS.ViewModel.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Concrete
{
    public class PaymentManager : Manager<PaymentDto, PaymentViewModel, Payment>
    {
        public PaymentManager(Service<Payment, PaymentDto> service) : base(service)
        {
        }
    }
}
