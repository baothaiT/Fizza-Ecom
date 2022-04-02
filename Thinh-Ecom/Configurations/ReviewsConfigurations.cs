﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Thinh_Ecom.Configurations
{
    public class ReviewsConfigurations : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.ToTable("Reviews");
            builder.HasKey(t => new { t.review_id });
            builder.HasOne(t => t.AppUserR).WithMany(ur => ur.ReviewsU)
     .HasForeignKey(pc => pc.review_UserId);
        }
    }
}
