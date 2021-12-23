using MBShopApp.Business.Abstract;
using MBShopApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MBShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
       
        public HomeController(IProductService productService)
        {
            _productService=productService;
            
        }
        public IActionResult Index()
        {
            
            return View(new ProductListModel()
            {
                Products=_productService.GetAll()
                
            });
        }
    }
}
