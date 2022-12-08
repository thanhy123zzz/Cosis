using Cosis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosis.Controllers
{
    public class Form1_2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/form1_2")]
        public IActionResult InsertForm1_2(PhieuDieuTra phieu)
        {

            return RedirectToAction("Index");
        }
    }
}
