
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Thinh_Ecom.Configurations
{
    public class DeviceInfoConfigurations : IEntityTypeConfiguration<DeviceInfo>
    {

        public void Configure(EntityTypeBuilder<DeviceInfo> builder)
        {
            builder.ToTable("Device");
            builder.HasKey(t => new { t.deviceId });



        }
    }
}
