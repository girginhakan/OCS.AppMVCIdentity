using OCS.BLL.Managers.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Managers.Concrete
{
    public class ProductManager : Manager<ProductDto, ProductViewModel, Product>
    {
        public ProductManager(Service<Product, ProductDto> service) : base(service)
        {
        }
    }
}
