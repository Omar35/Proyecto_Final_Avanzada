using Proyecto_Final_Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_Avanzada.Controllers
{
    public class CarteleraController : Controller
    {
        private cineEntities db = new cineEntities();

        // GET: Cartelera
        public ActionResult Index()
       {
            return View(db.pelicula.ToList());
        }
    }
}