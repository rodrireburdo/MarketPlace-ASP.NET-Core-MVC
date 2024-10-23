using AppCrud.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppCrud.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(ApplicationDbContext context) 
            : base(context) { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
