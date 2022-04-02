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
    public class CartsDeviceConfigurations : IEntityTypeConfiguration<CartsDevice>
    {

        public void Configure(EntityTypeBuilder<CartsDevice> builder)
        {
            builder.ToTable("CartsDevice");
            builder.HasKey(t => new { t.cartd_Id });
            builder.HasOne(t => t.DeviceCD).WithMany(ur => ur.CartsDeviceD)
     .HasForeignKey(pc => pc.cartd_DeviceId);


        }
    }
}
