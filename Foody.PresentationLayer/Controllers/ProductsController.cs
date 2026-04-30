using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductService _productService;
        public ProductsController(IProductService productService123)
        {
//  bu methodun ismi "Constructor method" bunu arastir.
            _productService = productService123;
        }


        public IActionResult ProductList()
        {
            var values123 = _productService.TGetAll();
            return View(values123);
        }
    }
}
