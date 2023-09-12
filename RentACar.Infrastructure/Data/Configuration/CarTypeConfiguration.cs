using Microsoft.Data.SqlClient;
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
    public class CarTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.CarID);

            builder.Property(x => x.CarID)
                .UseIdentityColumn(1, 1);

            //builder.HasOne<Customer>(x => x.Customer)
            //    .WithMany(x => x.Cars)
            //    .HasForeignKey(x => x.CustomerID);

            builder.HasOne<CarPark>(x => x.CarPark)
                .WithOne(x => x.Car)
                .HasForeignKey<Car>("CarParkID");
        }
    }
}
