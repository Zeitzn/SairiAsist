using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sairi.ModuloAsistencia.DataContract;
using Sairi.ModuloAsistencia.DataAccess;

namespace Sairi.ModuloAsistencia.BussinesLogic
{
    public class AsistenciaDocenteBL : IAsistenciaDocenteBL
    {

        private readonly IAsistenciaDocenteDA _asistencia = new AsistenciaDocenteDA();
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
