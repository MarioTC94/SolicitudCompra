namespace SolicitudCompra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Solicitud_compra
    {
        [Key]
        public int IdSolicitudCompra { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaAtendido { get; set; }

        public int? IdEstadoCompra { get; set; }

        [StringLength(15)]
        public string Codigo_Producto { get; set; }

        public virtual EstadoCompra EstadoCompra { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
