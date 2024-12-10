using Microsoft.AspNetCore.Mvc;

namespace AP2_MVC_DOTNET.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}