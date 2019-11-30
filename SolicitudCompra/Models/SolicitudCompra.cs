namespace SolicitudCompra.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Solicitudcompra : DbContext
	{
		public Solicitudcompra()
			: base("name=SolicitudCompra")
		{
		}

		public DbSet<Categoria> Categoria { get; set; }
		public DbSet<EstadoCompra> EstadoCompra { get; set; }
		public DbSet<InfoCliente> InfoCliente { get; set; }
		public DbSet<Producto> Producto { get; set; }
		public DbSet<Solicitud_compra> Solicitud_compra { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categoria>()
				.Property(e => e.Codigo_categoria)
				.IsUnicode(false);

			modelBuilder.Entity<Categoria>()
				.Property(e => e.Descripcion)
				.IsUnicode(false);

			modelBuilder.Entity<EstadoCompra>()
				.Property(e => e.Descripcion)
				.IsUnicode(false);

			modelBuilder.Entity<InfoCliente>()
				.Property(e => e.NumeroCliente)
				.IsUnicode(false);

			modelBuilder.Entity<InfoCliente>()
				.Property(e => e.Nombre)
				.IsUnicode(false);

			modelBuilder.Entity<InfoCliente>()
				.Property(e => e.Apellido)
				.IsUnicode(false);

			modelBuilder.Entity<InfoCliente>()
				.Property(e => e.Correo)
				.IsUnicode(false);

			modelBuilder.Entity<InfoCliente>()
				.Property(e => e.DescripcionProducto)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Codigo_Producto)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Descripcion)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Detalle)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.PrecioTotal)
				.HasPrecision(10, 2);

			modelBuilder.Entity<Solicitud_compra>()
				.Property(e => e.Codigo_Producto)
				.IsUnicode(false);
		}
	}
}
