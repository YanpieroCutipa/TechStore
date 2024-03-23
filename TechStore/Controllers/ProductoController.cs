using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre,Descripcion,Precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {

                ViewData["Message"] = "Registro correcto! " +
                    "\nNombre: " + producto.Nombre +
                    "\nDescripcion: " + producto.Descripcion +
                     "\nPrecio: " + producto.Precio +
                    "\nIGV (18%): " + producto.IGV();

                return View("Index");
            }

            return View("Index");
        }
    }
}
