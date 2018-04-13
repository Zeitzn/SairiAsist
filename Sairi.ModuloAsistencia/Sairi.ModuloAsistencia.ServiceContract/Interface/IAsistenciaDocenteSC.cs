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
    public interface IAsistenciaDocenteSC
    {
        [OperationContract]
        IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocente();
        //[OperationContract]
        //IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocenteByFecha(string fecha);
    }
}
