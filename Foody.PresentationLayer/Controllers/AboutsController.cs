using Foody.BusinessLayer.Abstract;
using Foody_EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IAboutService _aboutService;
        
        public AboutsController(IAboutService aboutService123)
        {
            _aboutService = aboutService123;
        }

        public IActionResult AboutList()
        {
            var degerler777 = _aboutService.TGetAll();
            return View(degerler777);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about111)
        {
            _aboutService.TInsert(about111);
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var deger = _aboutService.TGetById(id);
            return View(deger);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about123)
        {
            _aboutService.TUpdate(about123);
            return RedirectToAction("AboutList");
        }
    }
}
