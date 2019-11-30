namespace SolicitudCompra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categoria")]
    public partial class Categoria
    {
        [Key]
        [StringLength(50)]
        public string Codigo_categoria { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        public int CantidadDisponible { get; set; }
    }
}
