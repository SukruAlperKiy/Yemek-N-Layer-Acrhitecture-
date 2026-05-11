using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents_HomePage
{
    public class _DefaultFeatureSectionComponentPartial:ViewComponent
    {
        //bu kodlarin ne ise yaradigini ogren
        private readonly IFeatureService _featureService;

        public _DefaultFeatureSectionComponentPartial(IFeatureService featureService444)
        {
            _featureService = featureService444;
        }
        public IViewComponentResult Invoke()
        {
            var degerler = _featureService.TGetAll();
            return View(degerler);
        }
    }
}
