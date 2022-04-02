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
    public class ContactUsersConfigurations : IEntityTypeConfiguration<ContactUsers>
    {
        public void Configure(EntityTypeBuilder<ContactUsers> builder)
        {
            builder.ToTable("ContactUsers");
            builder.HasKey(t => new { t.cu_Id });
        }
    }
}
