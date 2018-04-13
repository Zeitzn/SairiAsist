using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;
using Sairi.ModuloAsistencia.DataAccess;

namespace Sairi.ModuloAsistencia.BussinesLogic
{
    public class AsistenciaEstudianteBL : IAsistenciaEstudianteBL
    {

        private readonly IAsistenciaEstudianteDA _asistencia = new AsistenciaEstudianteDA();
        public IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante()
        {
            return _asistencia.ListAsistenciaEstudiante();
        }
    }
}
