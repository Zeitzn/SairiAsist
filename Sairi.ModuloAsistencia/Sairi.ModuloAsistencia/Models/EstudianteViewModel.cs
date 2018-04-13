using Sairi.ModuloAsistencia.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sairi.ModuloAsistencia.Models
{
    public class EstudianteViewModel
    {
        public IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante { get; set; }
    }
}