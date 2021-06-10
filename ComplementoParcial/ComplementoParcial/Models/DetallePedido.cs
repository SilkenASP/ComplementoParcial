namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetallePedido")]
    public partial class DetallePedido
    {
        [Key]
        public int iddetalle { get; set; }

        public int? idpedido { get; set; }

        public int? iddiscos { get; set; }

        public int? cantidad { get; set; }

        public double? precioVenta { get; set; }

        public virtual discos discos { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
