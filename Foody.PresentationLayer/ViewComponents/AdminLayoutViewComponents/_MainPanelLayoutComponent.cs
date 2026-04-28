using Microsoft.AspNetCore.Mvc;
namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _MainPanelLayoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
