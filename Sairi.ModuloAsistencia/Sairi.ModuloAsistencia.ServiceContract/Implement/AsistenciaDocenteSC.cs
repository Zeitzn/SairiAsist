using Sairi.ModuloAsistencia.BussinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;

namespace Sairi.ModuloAsistencia.ServiceContract
{
    public class AsistenciaDocenteSC:IAsistenciaDocenteSC
    {
        private readonly IAsistenciaDocenteBL _asistencia = new AsistenciaDocenteBL();

        public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocente()
        {
            return _asistencia.ListAsistenciaDocente();
        }

        //public IEnumerable<AsistenciaDocenteResponse> ListAsistenciaDocenteByFecha(string fecha)
        //{
        //    return _asistencia.ListAsistenciaDocenteByFecha(fecha);
        //}
    }
}
