using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
