namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        [Key]
        public int idpedido { get; set; }

        public DateTime? fechaPedido { get; set; }

        public int? idcliente { get; set; }

        public int? idempleado { get; set; }

        [StringLength(250)]
        public string direccionEntrega { get; set; }

        public int? estado { get; set; }

        public virtual cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }

        public virtual empleado empleado { get; set; }
    }
}
