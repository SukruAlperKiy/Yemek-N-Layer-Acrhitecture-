using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultFeatureItemSectionComponentPartial:ViewComponent
    {
        private readonly IFeatureItemService _featureItemService;

        public _DefaultFeatureItemSectionComponentPartial(IFeatureItemService featureItemService9889)
        {
            _featureItemService = featureItemService9889;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _featureItemService.TGetAll();
            return View(degerler);
        }
    }
}
