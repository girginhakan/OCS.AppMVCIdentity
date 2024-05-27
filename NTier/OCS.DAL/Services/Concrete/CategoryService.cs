using OCS.DAL.Repositories.Abstract;
using OCS.DAL.Repositories.Concrete;
using OCS.DAL.Services.Abstract;
using OCS.DTO;
using OCS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.DAL.Services.Concrete
{
    public class CategoryService : Service<Category, CategoryDto>
    {
        public CategoryService(CategoryRepo repo) : base(repo)
        {
        }
    }
}
