using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebEscuela.Models;

namespace WebEscuela.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var escuela = new Escuela("Mi Escuela", 1950, "Chile", "Santiago", TiposEscuela.Primaria);
            return View(escuela);
        }

        // GET: Escuela/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Escuela/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escuela/Create
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

        // GET: Escuela/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Escuela/Edit/5
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

        // GET: Escuela/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Escuela/Delete/5
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