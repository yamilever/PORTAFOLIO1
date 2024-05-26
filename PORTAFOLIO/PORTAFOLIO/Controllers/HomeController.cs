using Microsoft.AspNetCore.Mvc;
using PORTAFOLIO.Models;
using System.Diagnostics;

namespace PORTAFOLIO.Controllers
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
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }
        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> { 
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "https://amazon.com/",
                ImagenURL = "/imagenes/Amazon.png"
            },
                 new Proyecto
            {
                Titulo = "NewYork Times",
                Descripcion = "Pagina de noticias en React",
                Link = "https://nytimes.com/",
                ImagenURL = "/imagenes/nytimes.png"
            },
                  new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades ",
                Link = "https://reddit.com/",
                ImagenURL = "/imagenes/Reddit.png"
            },
                   new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com/",
                ImagenURL = "/imagenes/steam.png"
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
