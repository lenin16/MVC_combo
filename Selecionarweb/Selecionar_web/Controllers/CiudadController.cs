using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Selecionar_web.Controllers
{
    public class CiudadController : Controller
    {
        // GET: Ciudad
        public ActionResult Inicio()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            using (Models.BD_AlumnoEntities db = new Models.BD_AlumnoEntities())
            {
                lst = (from c in db.Ciudad
                       select new SelectListItem
                       {
                           Value = c.Id.ToString(),
                           Text = c.Nombre
                       }).ToList();
            }
                return View(lst);
        }


        [HttpGet]
        public JsonResult Alumno(int idCiudad)
        {
            List<ElementJson> lst = new List<ElementJson>();
            using (Models.BD_AlumnoEntities db = new Models.BD_AlumnoEntities())
            {
                lst = (from a in db.Alumno
                       where a.CodCiudad == idCiudad
                       select new ElementJson
                       {
                           Value = a.Id,
                           Text = a.Nombres
                       }).ToList();
            }

            return Json(lst,JsonRequestBehavior.AllowGet);
        }

        public class ElementJson {
            public int Value { get; set; }
            public string Text { get; set; }
        }
    }
}