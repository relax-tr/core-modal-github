using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace modal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            Soru asd = new Soru();

            asd.soruList = new List<Soru>();
            asd.soruList.Add(new Soru


            { no=2,name="aaa",category="ttpp"});
                asd.soruList.Add(new Soru


            { no=3,name="sss",category="tt"});
                asd.soruList.Add(new Soru


            { no=1,name="dd",category="ii"});
                asd.soruList.Add(new Soru


            { no=4534,name="wefwe",category="wfefe"});


            return View(asd);
        }
    

        public ActionResult DuzenlePartial(int id)
        {
            Console.WriteLine("edfwerfgergre");
            return PartialView("_PartialOrtakDuzenle", id);
        } 
        
        public ActionResult deneme()
        {
            

            return View();
        }

        [HttpPost()]
        public IActionResult EditClient(int id)
        {
            Soru client = new Soru();

            Console.WriteLine();


            return PartialView("Partial2", client);

        }

        public IActionResult edit( String  name,String email,String address)
        {
            //return PartialView("Index");

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
