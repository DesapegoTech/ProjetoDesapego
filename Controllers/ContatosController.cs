using Microsoft.AspNetCore.Mvc;

namespace Desapego.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PageContatos()
        {
            return View();
        }
    }
}
