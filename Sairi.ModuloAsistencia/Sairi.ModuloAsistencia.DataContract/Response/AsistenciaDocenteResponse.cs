using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sairi.ModuloAsistencia.DataContract
{

    public class AsistenciaDocenteResponse
    {
        public int id { get; set; }

        public int id_docente { get; set; }

        public string nombres { get; set; }

        public string apellidos { get; set; }

        public string dni { get; set; }

        public string codigo { get; set; }

        public DateTime hora_ingreso { get; set; }

        public DateTime? hora_salida { get; set; }

        public DateTime fecha { get; set; }
    }
}
