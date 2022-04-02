
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Thinh_Ecom.Configurations
{
 
        public class SubReviewConfigurations : IEntityTypeConfiguration<SubReview>
        {
            public void Configure(EntityTypeBuilder<SubReview> builder)
            {
                builder.ToTable("SubReview");
                builder.HasKey(t => new { t.subReview_Id });
                builder.HasOne(t => t.AppUserSR).WithMany(ur => ur.SubReviewSR)
                .HasForeignKey(pc => pc.subReview_UserId);
        }
        }
    
}
