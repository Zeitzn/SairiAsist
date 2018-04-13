namespace Sairi.ModuloAsistencia.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsistenciaDocente")]
    public partial class AsistenciaDocente
    {
        public int id { get; set; }

        public int id_docente { get; set; }

        public DateTime hora_ingreso { get; set; }

        public DateTime? hora_salida { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public virtual Docente Docente { get; set; }
    }
}
