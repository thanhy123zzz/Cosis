using Cosis.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Linq;
namespace Cosis.Controllers
{
    public class Form2_1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("/submit")]
        public IActionResult Test(IFormCollection form)
        {
            // var ntah = form["NhanToAnhHuong"].ToArray();
            var yt1 = form["NhanToAnhHuong[1]"].ToString();
            var yt2 = form["NhanToAnhHuong[2]"].ToString();
            var yt3 = form["NhanToAnhHuong[3]"].ToString();
            var yt4 = form["NhanToAnhHuong[4]"].ToString();
            var yt5 = form["NhanToAnhHuong[5]"].ToString();
            var yt6 = form["NhanToAnhHuong[6]"].ToString();
            var yt7 = form["NhanToAnhHuong[7]"].ToString();
            var yt8 = form["NhanToAnhHuong[8]"].ToString();
            var yt9 = form["NhanToAnhHuong[9]"].ToString();
            var _context = new FormCosisContext();
            string[] yto = { yt1, yt2, yt3, yt4, yt5, yt6, yt7, yt8, yt9 };
            foreach (string x in yto)
            {
                if (x != "" && x != null)
                {
                    if (String.Equals(x, yt9))
                    {
                        if(!String.Equals(x, "") && !String.Equals(x, null)){
                            // Nhan to 9
                        // Console.WriteLine(x);
                        }
                    }
                    else
                    {
                        // Nhan to 1-8
                        // Console.WriteLine(x);
                    }

                }
            }
            return RedirectToAction("Index", "Form2_1");
        }
    }
}
