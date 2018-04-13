using Sairi.ModuloAsistencia.BussinesLogic;
using Sairi.ModuloAsistencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sairi.ModuloAsistencia.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly IAsistenciaEstudianteBL _estudiante = new AsistenciaEstudianteBL();

        public ActionResult Index()
        {
            EstudianteViewModel estudiante = new EstudianteViewModel()
            {
                ListAsistenciaEstudiante = _estudiante.ListAsistenciaEstudiante()
            };

            return View(estudiante);
        }
    }
}