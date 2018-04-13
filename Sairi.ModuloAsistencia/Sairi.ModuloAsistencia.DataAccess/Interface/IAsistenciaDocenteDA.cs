using Sairi.ModuloAsistencia.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sairi.ModuloAsistencia.DataAccess
{
    public interface IAsistenciaDocenteDA
    {
        IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocente();
        //IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocenteByFecha(string fecha);
    }
}
