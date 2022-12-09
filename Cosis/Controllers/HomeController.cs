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
using Syncfusion.XlsIO;
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
            var a = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}",mst1,mst2).FirstOrDefault();
            return PartialView("_Master",a);
        }

/*        [Route("/xlsx")]
        public IActionResult xlsx()
        {
           
        }*/

    }
}
