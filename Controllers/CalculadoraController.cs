using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using conexion.Models;

namespace conexion.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}