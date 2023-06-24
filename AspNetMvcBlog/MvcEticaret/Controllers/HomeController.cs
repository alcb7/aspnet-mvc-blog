using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var products = new List<Product>();
            products.Add(new Product() { Title = "320", OldPrice = 300, IsSale = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9oFwKzcxdmGlMCanOD3UePFqhNkfZ8TjnkA&usqp=CAU", StarCount = 5, Price = 400 });
            products.Add(new Product() { Title = "420", OldPrice = 400, IsSale = true, ImageUrl = "https://cdn.motor1.com/images/mgl/mp8Ao/s1/4x3/bmw-4er-coupe-2020.webp", StarCount = 5, Price = 500 });
            products.Add(new Product() { Title = "520", OldPrice = 500, IsSale = true, ImageUrl = "https://www.sixt.com.tr/storage/cache/8a56aa0e1652cc35ba2b445fe99f9e808e66d4dd.webp", StarCount = 5, Price = 600 });
            products.Add(new Product() { Title = "M4", OldPrice = 4000, IsSale = true, ImageUrl = "https://arabam-blog.mncdn.com/wp-content/uploads/2021/03/2021-bmw-m4-front-quarter-redesign-1068x601.jpg", StarCount = 5, Price = 5000 });
            products.Add(new Product() { Title = "M6", OldPrice = 5000, IsSale = true, ImageUrl = "https://www.truck1.com.tr/img/Diger_araclar_Binek_araba_BMW_M6_Coupe_4_4_V8_Competition_Pakket-xxl-8045/8045_6346928245193.jpg", StarCount = 5, Price = 5000 });
            products.Add(new Product() { Title = "M7", OldPrice = 3000, IsSale = true, ImageUrl = "https://www.carscoops.com/wp-content/uploads/2023/04/2024-BMW-i7-M70-xDrive-2409807-1024x576.jpg", StarCount = 5, Price = 4000 });
            products.Add(new Product() { Title = "X6", OldPrice = 3050, IsSale = true, ImageUrl = "https://cdni.autocarindia.com/Utils/ImageResizer.ashx?n=https://cdni.autocarindia.com/ExtraImages/20221028055952_X6_2.jpg", StarCount = 5, Price = 4050 });
            products.Add(new Product() { Title = "X7", OldPrice = 3060, IsSale = true, ImageUrl = "https://otomobilgazetesi.com/uploads/2022/04/13/140017_bmw-x7-2023-800-01.jpeg", StarCount = 5, Price = 4060 });

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}