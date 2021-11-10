using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatWebApplication.Controllers
{
    public class HomeController : Controller
    {

        ChatRoom room = ChatRoom.getInstance();
        // GET: Home
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
                return View("Usuario");
            else 
            {
                ViewBag.userName = Session["Usuario"].ToString();
                ViewBag.mensajes = room.Messages;
                return View();
            }
        }


        [HttpPost]
        public ActionResult Autenticar(string usuario)
        {
            Session["Usuario"] = usuario;
            return RedirectToAction("Index");
        }

            [HttpPost]
        public ActionResult EnviarMensaje(string texto)
        {

            var mensaje = new Message();
            mensaje.IP = Request.UserHostAddress;
            mensaje.Text = texto;
            mensaje.User = Session["Usuario"].ToString();

            room.Messages.Add(mensaje);

            return RedirectToAction("Index");
        }
    }
}