using AppCrud.Data;
using AppCrud.Models;
using AppCrud.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data.Common;
using System.Diagnostics;

namespace AppCrud.Controllers
{
    public class BaseController : Controller
    {
        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public override ViewResult View(string? viewName, object? model)
        {
            ViewBag.NumeroProductos = GetCarritoCount();
            return base.View(viewName, model);
        }

        protected int GetCarritoCount()
        {
            int count = 0;

            string? carritoJson = Request.Cookies["carrito"];

            if(!string.IsNullOrEmpty(carritoJson))
            {
                var carrito = JsonConvert.DeserializeObject<List<ProductoIdAndCantidad>>(carritoJson);
                if (carrito != null)
                {
                    count = carrito.Count;
                }
            }

            return count;
        }

        protected IActionResult HandleError(Exception e)
        {
            return View("Error", new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            });
        }

        protected IActionResult HandleDbError(DbException dbException)
        {
            var ViewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de base de datos",
                Details = dbException.Message
            };
            return View("Error", ViewModel);
        }

        protected IActionResult HandleDbUpdateError(DbUpdateException dbUpdateException)
        {
            var ViewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de actualizacion de base de datos",
                Details = dbUpdateException.Message
            };
            return View("Error", ViewModel);
        }
    }
}
