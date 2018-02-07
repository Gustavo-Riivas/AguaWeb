using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            int Dias;
            int Botella = 12;
            int Botellaxdia;

            DateTime hoy = DateTime.Today;
            TimeSpan resta = ProximoCumple - hoy;
            Dias = resta.Days;
            Botellaxdia = minutos * Botella * resta.Days;


            ViewBag.Dias = Dias;
            ViewBag.Botellas = Botellaxdia;

            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            
            return View();
        }

    }
}
