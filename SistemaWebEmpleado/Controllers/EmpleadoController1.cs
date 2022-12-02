using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Collections.Generic;
using System.Linq;


namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController1 : Controller
    {


     
            private readonly EmpleadoContext _context;

            public EmpleadoController1(EmpleadoContext context)
            {
                _context = context;
            }


            public IActionResult Index()
        {

            return View("Index", _context.empleados.ToList());
        }
        public IActionResult TraerUno(int id)
        {
          Empleado empleado = _context.empleados.Find(id);
            return View("index",empleado);
        }

        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);

        }

        [HttpPost]

        public IActionResult Create(Empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", empleado);
            }
            else
            {
                _context.empleados.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        
        public IActionResult ListaPorTitulo(string Titulo)
        {
            List<Empleado> lista = (from p in _context.empleados
                                    where p.Titulo == Titulo
                                    select p).ToList();
            return View("Index", lista);
        }

        [HttpGet]
       
        public IActionResult Detail(int id)
        {
            Empleado empleado = _context.empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }


            return View("Detail", empleado);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            Empleado empleado = _context.empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();

            }

            return View("Delete", empleado);

        }



        [HttpPost]
        
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = _context.empleados.Find(id);

            if (empleado != null)
            {
                _context.empleados.Remove(empleado);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", _context.empleados.ToList());
        }

    }
}
