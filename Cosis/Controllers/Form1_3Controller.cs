using Cosis.Models;
using Cosis.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Cosis.Controllers
{
    public class Form1_3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/form1_3")]
        public IActionResult InsertForm1_3(PhieuDieuTra phieu)
        {

            return RedirectToAction("Index");
        }
    }
}
