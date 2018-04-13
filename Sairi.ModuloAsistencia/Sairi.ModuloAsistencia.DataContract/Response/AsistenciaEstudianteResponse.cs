using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sairi.ModuloAsistencia.DataContract
{
    public class AsistenciaEstudianteResponse
    {
        public int id { get; set; }

        public int id_estudiante { get; set; }

        public int id_nivel { get; set; }

        public string nombres { get; set; }

        public string apellidos { get; set; }

        public string dni { get; set; }

        public string codigo { get; set; }

        public DateTime hora_ingreso { get; set; }

        public DateTime? hora_salida { get; set; }

        public DateTime fecha { get; set; }
    }
}
