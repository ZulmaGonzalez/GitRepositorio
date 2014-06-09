using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Me_has_visto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];

            object model = null;
            if (model == null)
            return RedirectToAction("NotFound");
            return View(model);
           
            
        }
        public ActionResult NotFound()
        {
            ViewBag.ErrorCode = "NF0001";
            ViewBag.Description = "La mascota no se encuestra" +
               "en la base de datos";
            return View();

           // ViewData["ErrorCode"] = "NF0001";
           // ViewData["Description"] = "La mascota no se encuestra" +
             //   "en la base de datos";
            //return View(); 
        }
        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\zulma\Pictures/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture,contentType,fileName);
        }

        public HttpStatusCodeResult UnauthorizedError()
        {
            return new HttpUnauthorizedResult("Errorr de acceso no autorizado");
        }

        public ActionResult NotFoundError()
        {
            return HttpNotFound("Nada por aqui...");
        }

        //Action Method que permite la carga
        //de la foto de una mascota
        public ActionResult PictureUpload()
        {
            return View();
        }
    }
}
