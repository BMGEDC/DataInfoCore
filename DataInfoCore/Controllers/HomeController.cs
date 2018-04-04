using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataInfoCore.Models;
using DataInfoCore.Data;

namespace DataInfoCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //DataContext dc = new DataContext();
            //var q =
            //        (from a in dc.Market
            //        where a.Status == "A"
            //        select a).OrderBy(x => x.MarketCode);
            //var myObject = q.SingleOrDefault();
            //foreach (Char i in myObject.MarketCode ){
            //    Console.WriteLine(i);

            //}
            return View();
        }

        public IActionResult Markets()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
