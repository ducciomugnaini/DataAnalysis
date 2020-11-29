using Microsoft.AspNetCore.Mvc;

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
