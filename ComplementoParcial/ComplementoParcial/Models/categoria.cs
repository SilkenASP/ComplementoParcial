namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("categoria")]
    public partial class categoria
    {
        [Key]
        public int idcategoria { get; set; }

        [StringLength(50)]
        public string nombreCategoria { get; set; }
    }
}
