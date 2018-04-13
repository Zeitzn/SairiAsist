namespace Sairi.ModuloAsistencia.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docente")]
    public partial class Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docente()
        {
            AsistenciaDocente = new HashSet<AsistenciaDocente>();
        }

        public int id { get; set; }

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
        [StringLength(8)]
        public string codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaDocente> AsistenciaDocente { get; set; }
    }
}
