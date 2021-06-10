namespace ComplementoParcial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("artista")]
    public partial class artista
    {
        [Key]
        public int idartista { get; set; }

        [StringLength(150)]
        public string nombre { get; set; }

        [StringLength(150)]
        public string apellido { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        [StringLength(150)]
        public string lugarNacimiento { get; set; }

        [StringLength(100)]
        public string email { get; set; }
    }
}
