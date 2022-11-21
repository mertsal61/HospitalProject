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

                
        public IActionResult RaporSil(int id)
        {
            var value = reportmanager.Tgetbyid(id);
            reportmanager.TDeletel(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RaporGuncelle(int id)
        {
            var value=reportmanager.Tgetbyid(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult RaporGuncelle(Reports p)
        {
            var value = reportmanager.Tgetbyid(p.reportId);
            reportmanager.TUpdate(p);
            return RedirectToAction("Index");

        }

        
    }
}
