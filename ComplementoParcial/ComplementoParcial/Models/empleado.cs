namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleado")]
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            Pedido = new HashSet<Pedido>();
        }

        [Key]
        public int idempleado { get; set; }

        [StringLength(250)]
        public string nombres { get; set; }

        [StringLength(250)]
        public string apellidos { get; set; }

        [StringLength(250)]
        public string direccion { get; set; }

        [StringLength(25)]
        public string username { get; set; }

        [StringLength(25)]
        public string clave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
