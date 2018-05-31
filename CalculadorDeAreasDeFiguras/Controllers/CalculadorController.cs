using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculadorDeAreasDeFiguras.Services;
using CalculadorDeAreasDeFiguras.Models;

namespace CalculadorDeAreasDeFiguras.Controllers
{
    public class CalculadorController : Controller
    {
        CalculadorServices calculadorServices = new CalculadorServices();

        public ActionResult Cuadrados()
        {
            return View();
        }

        public ActionResult Triangulos()
        {
            return View();
        }

        public ActionResult Resultados()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cuadrados(Figura c)
        {
            if (ModelState.IsValid)
            {
                c = calculadorServices.calcularCuadrado(c);
                calculadorServices.agregarResultado(c);

                ViewBag.resultados = calculadorServices.listar();

                return View("Resultados");
            }

            else
            {
                return View();
            }


        }

        [HttpPost]
        public ActionResult Triangulos(Figura t)
        {

            if (ModelState.IsValid)
            {
                t = calculadorServices.calcularTriangulo(t);
                calculadorServices.agregarResultado(t);

                ViewBag.resultados = calculadorServices.listar();

                return View("Resultados");
            }

            else {
                return View();
            }
        }

    }
}
