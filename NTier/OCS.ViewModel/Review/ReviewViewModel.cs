using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.Review
{
    public class ReviewViewModel:BaseViewModel
    {
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }



        public ProductViewModel ProductViewModel { get; set; }

    }
}
