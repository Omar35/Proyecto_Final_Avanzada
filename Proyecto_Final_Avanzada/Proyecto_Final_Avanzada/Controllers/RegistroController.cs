using Proyecto_Final_Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_Avanzada.Controllers
{
    public class RegistroController : Controller
    {
        private cineEntities db = new cineEntities();


        private cliente ConvertirCliente(RegistroViewModel obj)
        {
            cliente objeto = new cliente

            {
                cl_idCliente =(int) obj.cl_idCliente,
                cl_nombre = obj.cl_nombre,
                cl_apellido1 = obj.cl_apellido1,
                cl_apellido2 = obj.cl_apellido2,
                cl_telefono = obj.cl_telefono
            };
            return objeto;
        }

        public Users ConvertirUsuario(RegistroViewModel obj)
        {
            Users objeto = new Users
            {
                UserId = (int)obj.cl_idCliente,
                UserName = obj.cl_usuario,
                nombre = obj.cl_nombre + " " + obj.cl_apellido1 + " " + obj.cl_apellido2,
                Password = obj.cl_contrasena
            };
            return objeto;
        }




        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegistroViewModel registroViewModel)
        {
            if (ModelState.IsValid)
            {

                db.cliente.Add(ConvertirCliente(registroViewModel));
                db.Users.Add(ConvertirUsuario(registroViewModel));
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(registroViewModel);

        }
  







        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

