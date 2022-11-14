using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
