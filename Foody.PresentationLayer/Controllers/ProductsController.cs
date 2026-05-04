using Foody.BusinessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService123, ICategoryService categoryService123)
        {
            //  bu methodun ismi "Constructor method" bunu arastir.
            _productService = productService123;
            _categoryService = categoryService123;
        }

        //[ProductList]
        //public IActionResult ProductList()
        //{
        //    var values123 = _productService.TGetAll();
        //    return View(values123);
        //}

        public IActionResult ProductListWithCategory()
        {
            var values333 = _productService.TProductListesiCategorisiIleBirlikte();
            return View(values333);
        }
        
        [HttpGet]
        public IActionResult CreateProduct()
        {
            // 1. Veritabanından kategorileri çekiyoruz
            var kategoriler = _categoryService.TGetAll();

            // 2. Bu listeyi ViewBag'e "KategorilerViewBagi" adıyla paketliyoruz
            // SelectList: Arayüzdeki <select> elementinin anlayacağı özel bir formattır
            ViewBag.KategorilerViewBagi = new SelectList(kategoriler, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product123)
        {
            _productService.TInsert(product123);
            return RedirectToAction("ProductListWithCategory");
        }



        //  Buradaki (int id) kisminda "id"yi kafana gore "id123" yapamiyorsun.
        //  Eger ismi tam olarak "id" olmazsa yakalayamiyor.
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
    //  burada kategorilerin hepsini SelectList(); seklinde getirdik.
            var aaaa = _categoryService.TGetAll();
            ViewBag.urunKategorisi = new SelectList(aaaa, "CategoryId", "CategoryName");

    //  Bu satir, hangi producta bastiysan onu getirmene yarar.
            var urunDegerleri = _productService.TGetById(id);

    //  Bu return de isin bitince idsi ile birlikte gelen productu degistirir.
            return View(urunDegerleri);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product123)
        {
            _productService.TUpdate(product123);
            return RedirectToAction("ProductListWithCategory");
        }
    }
}
