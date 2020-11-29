using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnalysisAPI.Controllers
{
    public class UnderAuthTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
