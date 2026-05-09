using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        //yeni degistirdiklerim <script src="assets/js/plugin/jquery-scrollbar/jquery.scrollbar.min.js"></script>
        // bunlari da degistirdim = <script src="assets/js/core/jquery-3.7.1.min.js"></script>
        /*bu satiri da ekledim 
        <script>
          $.fn.scrollbar = $.fn.scrollbar || function() { return this; };
      </script>*/

        public IActionResult Index()
        {
            return View();
        }
    }
}
