using Sairi.ModuloAsistencia.BussinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;

namespace Sairi.ModuloAsistencia.ServiceContract
{
    public class AsistenciaEstudianteSC:IAsistenciaEstudianteSC
    {
        private readonly IAsistenciaEstudianteBL _asistencia = new AsistenciaEstudianteBL();

        public IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante()
        {
            return _asistencia.ListAsistenciaEstudiante();
        }
    }
}
