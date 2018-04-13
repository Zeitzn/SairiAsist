using Sairi.ModuloAsistencia.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Sairi.ModuloAsistencia.ServiceContract
{
    [ServiceContract]
    public interface IAsistenciaEstudianteSC
    {
        [OperationContract]
        IEnumerable<AsistenciaEstudianteResponse> ListAsistenciaEstudiante();
    }
}
