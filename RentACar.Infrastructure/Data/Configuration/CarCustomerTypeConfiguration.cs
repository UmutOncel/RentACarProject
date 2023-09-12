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
    public class CarCustomerTypeConfiguration : IEntityTypeConfiguration<CarCustomer>
    {
        public void Configure(EntityTypeBuilder<CarCustomer> builder)
        {
            //builder.HasKey(x => new { x.CarID, x.CustomerID });

            builder.HasKey(x => x.CarCustomerID);

            builder.Property(x => x.PickUpDate)
                .IsRequired();

            builder.Property(x => x.DeliveryDate)
                .IsRequired();

            builder.HasOne<Car>(x => x.Car)
                .WithMany(x => x.CarCustomers)
                .HasForeignKey(x => x.CarID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne<Customer>(x => x.Customer)
                .WithMany(x => x.CarCustomers)
                .HasForeignKey(x => x.CustomerID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
