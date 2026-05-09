using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultAboutSectionComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutSectionComponentPartial(IAboutService aboutService333)
        {
            _aboutService = aboutService333;
        }
        public IViewComponentResult Invoke()
        {
            var hakkimizdalar = _aboutService.TGetAll();
            return View(hakkimizdalar);
        }
    }
}
