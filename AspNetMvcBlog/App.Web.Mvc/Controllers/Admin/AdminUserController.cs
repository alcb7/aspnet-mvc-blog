using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Admin
{
    public class AdminUserController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
