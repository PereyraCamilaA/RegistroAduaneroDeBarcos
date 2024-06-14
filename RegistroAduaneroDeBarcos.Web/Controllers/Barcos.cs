using Microsoft.AspNetCore.Mvc;
using RegistroAduaneroDeBarcos.Web.Models;
using RegistroDeBarcos.Logica.Services;

namespace RegistroAduaneroDeBarcos.Web.Controllers
{
    public class Barcos : Controller
    {
        private readonly IBarcosService _barcosService;

        public Barcos(IBarcosService barcosService)
        {
            _barcosService = barcosService;
        }

        public IActionResult RegistrarBarco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarBarco(BarcoModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _barcosService.RegistrarBarco(model.MapearAEntidad());

            return RedirectToAction("Listado");
        }

        public IActionResult Listado()
        {
            var barcos = _barcosService.ObtenerBarcos();
            var barcosModelLista = BarcoModel.MapearAListaModel(barcos);

            return View(barcosModelLista);
        }
    }
}