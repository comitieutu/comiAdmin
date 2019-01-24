using ComiCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.ModelConfig
{
    public class SaleOrderConfig : IEntityTypeConfiguration<SaleOrder>
    {
        public void Configure(EntityTypeBuilder<SaleOrder> builder)
        {
            builder.Property(s => s.OrderNumber)
                .HasComputedColumnSql("isnull(N'SO'+CONVERT([nvarchar](23),[Id]),N'*** ERROR ***')");
            builder.HasOne(s => s.ReceiveProduct)
                .WithOne(s => s.SaleOrder)
                .HasForeignKey<ReceiveProduct>(r => r.SaleId);
        }
    }
}
