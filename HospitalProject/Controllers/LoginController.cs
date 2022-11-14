using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
