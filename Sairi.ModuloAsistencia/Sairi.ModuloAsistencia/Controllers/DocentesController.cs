using Sairi.ModuloAsistencia.BussinesLogic;
using Sairi.ModuloAsistencia.DataAccess;
using Sairi.ModuloAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sairi.ModuloAsistencia.Controllers
{
    public class DocentesController : Controller
    {

        private readonly IAsistenciaDocenteBL _docente = new AsistenciaDocenteBL();

        public ActionResult Index()
        {
            DocenteViewModel docente = new DocenteViewModel()
            {
                ListAsistenciaDocente = _docente.ListAsistenciaDocente()
            };

            return View(docente);
        }



        //public ActionResult Listar(string fecha)
        //{
            
        //    DocenteViewModel docentes = new DocenteViewModel()
        //    {
        //        ListAsistenciaDocenteByFecha = docentebl.ListAsistenciaDocenteByFecha(fecha)
        //    };

        //    return View(docentes);
        //}




    }
}