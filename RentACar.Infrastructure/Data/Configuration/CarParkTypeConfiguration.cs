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
    public class CarParkTypeConfiguration : IEntityTypeConfiguration<CarPark>
    {
        public void Configure(EntityTypeBuilder<CarPark> builder)
        {
            builder.HasKey(x => x.CarParkID);

            builder.Property(x => x.CarParkID)
                .UseIdentityColumn(1, 1);

            builder.HasOne<CarParkFloor>(x => x.CarParkFloor)
                .WithMany(x => x.CarParks)
                .HasForeignKey(x => x.CarParkFloorID);
        }
    }
}
