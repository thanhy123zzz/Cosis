﻿using Cosis.Models;
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
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}",mst1,mst2).FirstOrDefault();
            return PartialView("_Master",a);
        }
        // xd
        [HttpPost("/loadMaster2")]
        public IActionResult loadInfor(string ms)
        {
            FormCosisContext context = new FormCosisContext();
            string mst1 = ms.Substring(0, 10);
            string mst2 = ms.Substring(10);
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            var a1 = context.ThongTinCaThe.FromSqlRaw("select*from ThongTinCaThe where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            var b = context.Master.FromSqlRaw("select*from Master where MaSoThue = {0} and MaSoThue2 = {1}", mst1, mst2).FirstOrDefault();
            Console.WriteLine(a1);
            if (a1 == null)
            {
                a1 = new ThongTinCaThe();
                b.MaSoThueNavigation = a;
                b.MaCoSoNavigation =a1;
            }
            else
            {
                b.MaCoSoNavigation = a1;
                b.MaSoThueNavigation = a;
            }
            return PartialView("_Master2_1", b);
        }
    }
}
