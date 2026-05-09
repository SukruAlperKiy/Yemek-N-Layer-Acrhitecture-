using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultSldierSectionComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSldierSectionComponentPartial(ISliderService sliderService123)
        {
            _sliderService = sliderService123;
        }
        public IViewComponentResult Invoke()
        {
            var degerler = _sliderService.TGetAll();
            return View(degerler);
        }
    }
}
