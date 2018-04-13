using Sairi.ModuloAsistencia.DataAccess;
using Sairi.ModuloAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sairi.ModuloAsistencia.Controllers
{
    public class CalendarioController : Controller
    {
        //DocenteService.AsistenciaDocenteSCClient _docente = new DocenteService.AsistenciaDocenteSCClient();

        public ActionResult Index()
        {
            return View();
        }

        
        //public JsonResult ListAsistenciaDocenteByFecha(int? fechaParam)
        //{

        //    DocenteViewModel docente = new DocenteViewModel()
        //    {
        //        //ListAsistenciaDocenteByFecha = _docente.ListAsistenciaDocenteByFecha(fecha)
        //        ListAsistenciaDocenteByFecha = _docente.ListAsistenciaDocenteByFecha(23)
        //    };


        //    return Json(docente.ListAsistenciaDocenteByFecha, JsonRequestBehavior.AllowGet);
        //}
    }
}