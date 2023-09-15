using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id);

        builder.Property(e => e.Nombre)
            .HasColumnName("Nombre")
            .HasColumnType("varchar")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(e => e.Precio)
            .HasColumnName("precio")
            .HasColumnType("decimal(18, 2)")
            .IsRequired();

        builder.Property(e => e.FechaCreacion)
            .HasColumnName("FechaCreacion")
            .HasColumnType("DateTime")
            .HasMaxLength(50)
            .IsRequired();

        builder.HasOne(d => d.Marca)
            .WithMany(d => d.Productos)
            .HasForeignKey(d => d.MarcaId);

        builder.HasOne(d => d.Categoria)
            .WithMany(d => d.Productos)
            .HasForeignKey(d => d.CategoriaId);
    }
}