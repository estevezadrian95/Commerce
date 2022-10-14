using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasIndex(p => p.ProductInStockId);// Especifico que la tabla tiene una PK

            var stocks = new List<ProductInStock>();
            var random = new Random();
            
            for(int i = 1; i <= 100; i++)
            {
                stocks.Add(new ProductInStock { ProductId = i, ProductInStockId = i, Stock = random.Next(0, 200) });
            }

            entityBuilder.HasData(stocks);
        }
    }
}
