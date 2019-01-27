using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mapss.Models;

namespace Mapss.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            PaginaMapa pm = new PaginaMapa();
            Punto p1 = new Punto(-77.041, -12.0555, 1, "sede principal");
            Punto p2 = new Punto(-77.0365, -12.066, 1, "sucursal ventas");
            Punto p3 = new Punto(-77.0694, -12.048, 1, "sucursal TI");
            Punto p4 = new Punto(-77.0536, -12.0077, 2, "sucursal admin");
            Punto p5 = new Punto(-76.97639, -12.09136, 2, "sucursal almacen");
            pm.puntos.Add(p1);
            pm.puntos.Add(p2);
            pm.puntos.Add(p3);
            pm.puntos.Add(p4);
            pm.puntos.Add(p5);
            Session["todosPuntos"] = pm.puntos;
            
            return View(pm);
        }

        [HttpPost]
        public ActionResult Index(PaginaMapa obj)
        {
            List<Punto> todosPuntos = new List<Punto>();
            todosPuntos = (List<Punto>)Session["todosPuntos"];

            List<Punto> puntosPorEstado;
            if (obj.estadoId != 0)
            {
                puntosPorEstado = todosPuntos.Where(u => u.estadoId == obj.estadoId).ToList();
            }
            else {
                puntosPorEstado = todosPuntos;
            }

            PaginaMapa pm = new PaginaMapa();
            pm.puntos = puntosPorEstado;
            //return Json(new { result = 0, data = puntosPorEstado }, JsonRequestBehavior.AllowGet);

            return View(pm);
        }

        [HttpGet]
        public ActionResult ListPuntosByEstado(int Estado)
        {
            List<Punto> todosPuntos = new List<Punto>();
            todosPuntos = (List<Punto>)Session["todosPuntos"];

            List<Punto> puntosPorEstado = todosPuntos.Where(u => u.estadoId == Estado).ToList();

            return Json(new { result = 0, data = puntosPorEstado }, JsonRequestBehavior.AllowGet);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
