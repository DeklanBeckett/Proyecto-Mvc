using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class DashController : Controller{
        public IActionResult Index(){
            return View();

        }
        
    }
}