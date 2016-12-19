using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using SeguridadWebv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadWebv2.Controllers
{
    [Authorize]
    public class VideoConferenciaController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: VideoConferencia
        public ActionResult Iniciar(string id)
        {
            ApplicationUserManager UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var usuario = User.Identity.GetUserId();
            if (usuario == null)
            {
                return HttpNotFound();
            }
            var rol = UserManager.GetRoles(usuario);
            var turno = db.Turnos.Where(x => x.IdTurno == id).FirstOrDefault();
            ViewBag.FechaFin = (turno.HoraFin - DateTime.Now);
            return View();
        }
    }
}