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

//  Kumpir alirken Garsonun bize bos bir kagit ve kalem vermesi gibi bu kod sadece bize sayfayi getirir. baska birsey yapmaz.
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

//  Kumpir alirken garsonun bize verdigi bos kagidi doldurduk ve garson kagidi iceriye mutfaga goturdu.
        [HttpPost]
        public IActionResult CreateCategory(Category category123)
        {
            _categoryService.TInsert(category123);
            return RedirectToAction("CategoryList");
        }



        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("CategoryList");
        }



        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var deger = _categoryService.TGetById(id);
            return View(deger);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category135)
        {
            _categoryService.TUpdate(category135);
            return RedirectToAction("CategoryList");
        }
    }
}
