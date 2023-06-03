using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Admin
{
    public class BaseAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
