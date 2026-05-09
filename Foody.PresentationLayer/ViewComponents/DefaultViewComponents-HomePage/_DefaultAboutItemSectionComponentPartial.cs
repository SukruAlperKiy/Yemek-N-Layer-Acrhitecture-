using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultAboutItemSectionComponentPartial:ViewComponent
    {
        private readonly IAboutItemService _aboutItemService;

        public _DefaultAboutItemSectionComponentPartial(IAboutItemService aboutItemService999)
        {
            _aboutItemService = aboutItemService999;
        }

        public IViewComponentResult Invoke()
        {
            var valueler = _aboutItemService.TGetAll();
            return View(valueler);

        }
    }
}
