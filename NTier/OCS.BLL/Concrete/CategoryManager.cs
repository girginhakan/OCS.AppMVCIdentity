using OCS.BLL.Abstract;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using OCS.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.BLL.Concrete
{
    public class CategoryManager : Manager<CategoryDto, CategoryViewModel, Category>
    {
        public CategoryManager(Service<Category, CategoryDto> service) : base(service)
        {
        }
    }
}
