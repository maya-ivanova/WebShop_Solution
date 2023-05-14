using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Contracts;

namespace WebShop.Controllers
{
    /// <summary>
    /// this is my sample 3in1 project
    /// </summary>
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        /// <summary>
        /// List all products. however, it is not such a simple task, as we need to extract and search these products from somewhere.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAllAsync();

            ViewData["Title"] = "Products";

            return View(products);
        }
    }
}
