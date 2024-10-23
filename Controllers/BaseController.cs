using AppCrud.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppCrud.Controllers
{
    public class BaseController : Controller
    {
        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
