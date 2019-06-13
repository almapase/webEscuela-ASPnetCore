using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebEscuela.Models;

namespace WebEscuela.Controllers
{
    public class AsignaturaController : Controller
    {
        // GET: Asignatura
        public ActionResult Index()
        {
            var asignatura = new Asignatura { Nombre = "Matemáticas" };
            return View(asignatura);
        }
        // GET: Asignatura
        public ActionResult Lista()
        {
            List<Asignatura> ListaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Física"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"}
                };
            return View(ListaAsignaturas);
        }

        // GET: Asignatura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asignatura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asignatura/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignatura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asignatura/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asignatura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asignatura/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}