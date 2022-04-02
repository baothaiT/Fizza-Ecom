
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Thinh_Ecom.Configurations
{
    public class ReviewInproductConfigurations : IEntityTypeConfiguration<ReviewInproduct>
    {
        public void Configure(EntityTypeBuilder<ReviewInproduct> builder)
        {
            builder.ToTable("ReviewInproduct");
            builder.HasKey(t => new { t.rip_ProductId, t.rip_ReviewId });
            builder.HasOne(t => t.ProductsRIP).WithMany(ur => ur.ReviewInproductP)
     .HasForeignKey(pc => pc.rip_ProductId);
            builder.HasOne(t => t.ReviewsRIP).WithMany(ur => ur.ReviewInproductR)
     .HasForeignKey(pc => pc.rip_ReviewId);
        }
    }
}
