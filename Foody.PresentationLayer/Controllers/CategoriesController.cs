using Foody.BusinessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService123)
        {
            _categoryService = categoryService123;
        }
        public IActionResult CategoryList()
        {
            var values123 = _categoryService.TGetAll(); 
            return View(values123);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category123)
        {
            _categoryService.TInsert(category123);
            return RedirectToAction("CategoryList");
        }
    }
}
