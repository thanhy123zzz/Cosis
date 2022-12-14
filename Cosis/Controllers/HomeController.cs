using Cosis.Models;
using Cosis.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Cosis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string result)
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost("/loadMaster")]
        public IActionResult loadDiaChi(string ms)
        {
            FormCosisContext context = new FormCosisContext();
            string mst1 = ms.Substring(0, 10);
            string mst2 = ms.Substring(10);
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            return PartialView("_Master", a);
        }
        // xd
        [HttpPost("/loadMaster2")]
        public IActionResult loadInfor(string ms)
        {
            FormCosisContext context = new FormCosisContext();
            string mst1 = ms.Substring(0, 10);
            string mst2 = ms.Substring(10);
            // var b = context.Master.FromSqlRaw("select*from Master where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            // Console.WriteLine(a1);
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            ViewBag.CheckMCS = 0;
            return PartialView("_Master2_1", a);
        }
        [HttpPost("/loadMaster2CN")]
        public IActionResult loadInforPersonal(string ms)
        {
            FormCosisContext context = new FormCosisContext();
            // var b = context.Master.FromSqlRaw("select*from Master where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            // Console.WriteLine(a1);
            var a = context.ThongTinCaThe.FromSqlRaw("select*from ThongTinCaThe where MaCoSo = {0}", ms).FirstOrDefault();
            ViewBag.CheckMCS = 0;
            return PartialView("_Master2_1CN", a);
        }
        [HttpPost("/loaddata_21B")]
        public IActionResult loaddata_21B(string ms)
        {
            Console.WriteLine("MS:"+ms+"length:"+ms.Length);
            FormCosisContext context = new FormCosisContext();
            var a = context.NganhKinhDoanh.ToList();
            if(ms.Length == 13){
            string mst1 = ms.Substring(0, 10);
            string mst2 = ms.Substring(10);
            a = context.NganhKinhDoanh.FromSqlRaw("select*from NganhKinhDoanh where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).ToList();
            }else{
             a = context.NganhKinhDoanh.FromSqlRaw("select*from NganhKinhDoanh where MaCoSo = {0}", ms).ToList();
            }
            Console.WriteLine(a.ToString());
            ViewBag.ListNghanh = a;
            return PartialView("_2_1B");
        }
    }
}
