using Microsoft.AspNetCore.Mvc;
using portafolio.Models;
using System.Diagnostics;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexDTO() {proyectos = proyectos};
            return View(modelo);
        }
        private List<ProyectoDTO> ObtenerProyectos() {
            return new List<ProyectoDTO>() { 
                new ProyectoDTO
                {
                    Titulo= "Bancolombia",
                    Descripcion= "Trabajando en el sector sucursal virtual personas",
                    Link= "https://www.bancolombia.com/personas",
                    ImgUrl = "/img/bancolombia.png"
                },
                new ProyectoDTO
                {
                    Titulo= "Sii x Salesforce",
                    Descripcion= "Trabajando en cloud de ventas con node.js y AWS",
                    Link= "https://sii.pl/en/what-we-offer/enterprise-platforms/salesforce/",
                    ImgUrl = "/img/salesforce.png"
                },
                new ProyectoDTO
                {
                    Titulo= "Amazon",
                    Descripcion= "E-Commerce realizado en ASP.NET Core",
                    Link= "https://amazon.com",
                    ImgUrl = "/img/amazon.png"
                },
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
