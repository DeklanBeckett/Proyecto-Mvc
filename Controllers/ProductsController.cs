using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class ProductsController : Controller{
        public IActionResult Index(){
            return View();
        }

        
        
    }
}