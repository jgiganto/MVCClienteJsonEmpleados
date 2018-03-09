using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using MVCClienteJsonEmpleados.Models;

namespace MVCClienteJsonEmpleados.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloEmpleados modelo;
        public EmpleadosController()
        {
            modelo = new ModeloEmpleados();
        }

        // GET: Empleados
        public ActionResult Index()
        {
            return View(modelo.GetEmpleados());
        }
        [HttpPost]
        public ActionResult Index(int? id,int? salario)
        {
            ViewBag.Empleado = modelo.GetEmpleado(id.GetValueOrDefault()) as Empleado;
            ViewBag.EmpleadosSalario = modelo.GetEmpleadosSalario(salario.GetValueOrDefault()) as List<Empleado>;

            return View(modelo.GetEmpleados());
        }
    }
}