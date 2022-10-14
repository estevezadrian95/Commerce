using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(p => p.ProductId);// Especifico que la tabla tiene una PK
            entityBuilder.Property(p => p.Name).IsRequired().HasMaxLength(100);// Campo obligatorio y que tiene como maximo 100 carateres
            entityBuilder.Property(p => p.Description).IsRequired().HasMaxLength(500);// Campo obligatorio y que tiene como maximo 500 carateres
            entityBuilder.Property(p => p.Price).HasPrecision(5, 2);
            //Genero una lista de precios aleatoria
            var products = new List<Product>();
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    ProductId = i,
                    Name = "Producto " + i.ToString(),
                    Description = "Descripcion " + i.ToString(),
                    Price = random.Next(100, 1500),
                });
            }
            // Agrego la data
            entityBuilder.HasData(products);
        }
    }
}
