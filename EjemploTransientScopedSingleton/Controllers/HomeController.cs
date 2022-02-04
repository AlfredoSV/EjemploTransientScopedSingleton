using EjemploTransientScopedSingleton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EjemploTransientScopedSingleton.Clases;

namespace EjemploTransientScopedSingleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient _transient;
        private readonly ISingleton _singleton;
        private readonly IScoped _scoped;


        private readonly ITransient _transient2;
        private readonly ISingleton _singleton2;
        private readonly IScoped _scoped2;

        public HomeController(ITransient transient, ISingleton singleton, IScoped scoped, ITransient transient2, ISingleton singleton2, IScoped scoped2)
        {
            _transient = transient;
            _singleton = singleton;
            _scoped = scoped;
            _transient2 = transient2;
            _singleton2 = singleton2;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
            ViewBag.t1 = _transient;
            ViewBag.t2 = _transient2;

            ViewBag.s1 = _scoped;
            ViewBag.s2 = _scoped2;

            ViewBag.s1s = _singleton;
            ViewBag.s2s = _singleton2;


            return View();
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
