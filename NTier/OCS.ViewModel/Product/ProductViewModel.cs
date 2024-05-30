using Microsoft.AspNetCore.Http;
using OCS.ViewModel.Category;
using OCS.ViewModel.OrderItem;
using OCS.ViewModel.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.Product
{
    public class ProductViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string PictureName { get; set; }
        public byte[] PictureFile { get; set; }

        public IFormFile FormFile { get; set; }
        public int CategoryId { get; set; }



        public CategoryViewModel CategoryViewModel { get; set; }
        public ICollection<OrderItemViewModel> OrderItemsViewModel { get; set; }
        public ICollection<ReviewViewModel> ReviewsViewModel { get; set; }
    }
}
