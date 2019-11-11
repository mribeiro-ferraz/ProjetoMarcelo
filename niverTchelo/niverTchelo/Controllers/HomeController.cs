using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using niverTchelo.Models;
using niverTchelo.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace niverTchelo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConvidadosService _convidadosService;

        public HomeController(ConvidadosService convidadosService)
        {
            _convidadosService = convidadosService;
        }

        //Actions
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Convidados(Convidados convidado)
        {
            if (ModelState.IsValid)
            {
                await _convidadosService.InsertAsync(convidado);
                return RedirectToAction(nameof(Lista));
            }
            else
            {
                return View(convidado);
            }
        }
        public async Task<IActionResult> Lista()
        {
            var result = await _convidadosService.Listar();
            return View(result);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
