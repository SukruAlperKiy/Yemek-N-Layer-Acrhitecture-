using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultProductSectionComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductSectionComponentPartial(IProductService productService3162)
        {
            _productService = productService3162;
        }

        public IViewComponentResult Invoke()
        {
            var degerler13 = _productService.TProductListWithCategoryAndLast12Items();
            return View(degerler13);
        }
    }
}
