namespace Sairi.ModuloAsistencia.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsistenciaEstudiante")]
    public partial class AsistenciaEstudiante
    {
        public int id { get; set; }

        public int id_estudiante { get; set; }

        public DateTime hora_ingreso { get; set; }

        public DateTime? hora_salida { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}
