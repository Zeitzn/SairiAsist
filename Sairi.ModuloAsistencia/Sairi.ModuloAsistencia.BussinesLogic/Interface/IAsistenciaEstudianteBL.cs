using Sairi.ModuloAsistencia.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sairi.ModuloAsistencia.BussinesLogic
{
    public interface IAsistenciaEstudianteBL
    {
        IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante();
    }
}
