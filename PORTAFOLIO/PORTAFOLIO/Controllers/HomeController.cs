﻿using Microsoft.AspNetCore.Mvc;
using PORTAFOLIO.Models;
using PORTAFOLIO.Servicios;
using System.Diagnostics;

namespace PORTAFOLIO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            _logger.LogTrace("Este es un mensaje de trace");
            _logger.LogDebug("Este es un mensaje de debug");
            _logger.LogInformation("Este es un mensaje de information");
            _logger.LogWarning("Este es un mensaje de warning");
            _logger.LogError("Este es un mensaje de error");
            _logger.LogCritical("Este es un mensaje de critical");

            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
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
