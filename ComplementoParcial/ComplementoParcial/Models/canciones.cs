namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class canciones
    {
        [Key]
        public int idcancion { get; set; }

        public int? iddisco { get; set; }

        public int? numero { get; set; }

        public double? tiempo { get; set; }

        [StringLength(150)]
        public string cancion { get; set; }
    }
}
