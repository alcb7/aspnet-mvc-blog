using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query,int id)
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
