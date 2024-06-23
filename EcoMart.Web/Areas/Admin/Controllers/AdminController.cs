using Microsoft.AspNetCore.Mvc;

namespace EcoMart.Web.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
