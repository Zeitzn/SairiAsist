using Sairi.ModuloAsistencia.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sairi.ModuloAsistencia.Models
{
    public class DocenteViewModel
    {
        public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocente { get; set; }
        //public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocenteByFecha { get; set; }
    }
}