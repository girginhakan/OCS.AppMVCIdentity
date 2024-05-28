using Microsoft.AspNetCore.Mvc;
using OCS.BLL.Concrete;

namespace OCS.AdminApp.Controllers
{
    public class CategoryController : Controller
    {
        
        private CategoryManager _categoryManager;
        //private ProductManager

        public IActionResult Index()
        {
            return View();
        }
    }
}
