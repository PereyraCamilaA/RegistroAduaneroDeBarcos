using Microsoft.AspNetCore.Mvc;

namespace RegistroAduaneroDeBarcos.Web.Controllers
{
    public class Inicio : Controller
    {
        public IActionResult Bienvenida()
        {
            return View();
        }
    }
}