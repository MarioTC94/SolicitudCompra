namespace SolicitudCompra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoCliente")]
    public partial class InfoCliente
    {
        [Key]
        public int Idcliente { get; set; }

        [Required]
        [StringLength(10)]
        public string NumeroCliente { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(30)]
        public string Correo { get; set; }

        public int CantidadSolicitada { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionProducto { get; set; }
    }
}
