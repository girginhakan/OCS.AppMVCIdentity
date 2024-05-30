using Microsoft.AspNetCore.Mvc;
using OCS.BLL.Managers.Concrete;
using OCS.ViewModel.Category;

namespace OCS.AdminApp.Controllers
{
    public class CategoryController : Controller
    {
        
        private CategoryManager _categoryManager;
        private ProductManager _productManager;

        public CategoryController(CategoryManager categoryManager, ProductManager productManager)
        {
            _categoryManager = categoryManager;
            _productManager = productManager;
        }


        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> categories = _categoryManager.GetAll();

            return View(categories);
        }
    }
}
