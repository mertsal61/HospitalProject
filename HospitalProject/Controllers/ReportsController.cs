using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.Controllers
{
    public class ReportsController : Controller
    {
        reportmanager reportmanager = new reportmanager(new Efreportdal());
        public IActionResult Index()
        {
            var values= reportmanager.TGetlist();
            return View(values);
        }

        [HttpGet]
        public IActionResult RaporEkle()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult RaporEkle(Reports p)
        {
            reportmanager.TInsert(p);
            return RedirectToAction("Index");
        }

        
    }
}
