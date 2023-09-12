using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Infrastructure.Data.Configuration
{
    public class CarParkFloorTypeConfiguration : IEntityTypeConfiguration<CarParkFloor>
    {
        public void Configure(EntityTypeBuilder<CarParkFloor> builder)
        {
            builder.HasKey(x => x.CarParkFloorID);

            builder.Property(x => x.CarParkFloorID)
                .UseIdentityColumn(1, 1);
        }
    }
}
