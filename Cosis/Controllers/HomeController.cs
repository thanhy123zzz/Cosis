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
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Cosis.Controllers
{
    [Authorize]
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
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}",mst1,mst2).FirstOrDefault();
            return PartialView("_Master",a);
        }
        [HttpPost("/loadMaster1")]
        public IActionResult loadMaster(string ms,string mast)
        {
            FormCosisContext context = new FormCosisContext();
            if (ms != null)
            {
                var a = context.Master.FirstOrDefault(x => x.MaPhieu == ms);
                return PartialView("_Master1_3", a);
            }
            else
            {
                var ttdn = context.ThongTinDoanhNghiep.FirstOrDefault(x => x.TaiKhoan == User.Identity.Name);
                Master a = getMaster(ttdn);
                return PartialView("_Master1_3", a);
            }
        }
        private Master getMaster(ThongTinDoanhNghiep tt)
        {
            Master master = new Master();
            master.Ten = tt.TenDoanhNghiep;
            master.MaSoThue = tt.MaSoThue;
            master.MaSoThue2 = tt.MaSoThue2;
            master.MaTinhTp = tt.MaTinhTp;
            master.MaQuanHuyen = tt.MaQuanHuyen;
            master.MaPhuongXa = tt.MaPhuongXa;
            master.DiaChiCuThe = tt.DiaChiCuThe;
            master.Sdt = tt.SdtdoanhNghiep;
            master.Email = tt.Email;
            master.MaLh = tt.MaLh;
            return master;
        }
        /*        [Route("/xlsx")]
                public IActionResult xlsx()
                {

                }*/

    }
}
