using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class UsersController : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Create(){
            return View();
        }

        public IActionResult Show(){
            return View();
        }

        public IActionResult Edit(){
            return View();
        }

        public IActionResult Update(){
            return View();
        }
        public IActionResult Eliminar(){
            return View();
        }
        
    }
}