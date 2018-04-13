namespace Sairi.ModuloAsistencia.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            AsistenciaEstudiante = new HashSet<AsistenciaEstudiante>();
        }

        public int id { get; set; }

        public int id_nivel { get; set; }

        [Required]
        [StringLength(100)]
        public string nombres { get; set; }

        [Required]
        [StringLength(200)]
        public string apellidos { get; set; }

        [StringLength(8)]
        public string dni { get; set; }

        [Required]
        [StringLength(500)]
        public string foto { get; set; }

        [Required]
        [StringLength(9)]
        public string codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaEstudiante> AsistenciaEstudiante { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
