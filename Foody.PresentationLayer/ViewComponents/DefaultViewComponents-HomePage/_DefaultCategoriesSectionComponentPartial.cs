using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultCategoriesSectionComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoriesSectionComponentPartial(ICategoryService categoryService665)
        {
            _categoryService = categoryService665;
        }
        public IViewComponentResult Invoke()
        {
            var degerler = _categoryService.TGetAll();
            return View(degerler);
        }
    }
}
