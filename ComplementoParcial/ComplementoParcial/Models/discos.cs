namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class discos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public discos()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        [Key]
        public int iddisco { get; set; }

        public int? idcategoria { get; set; }

        public int? idartista { get; set; }

        [StringLength(50)]
        public string titulo { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(150)]
        public string formato { get; set; }

        public int? numeroCanciones { get; set; }

        public double? precio { get; set; }

        [StringLength(500)]
        public string observaciones { get; set; }

        [StringLength(500)]
        public string imagen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
