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
    public class CustomerTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.CustomerID);

            builder.Property(x => x.CustomerID)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.CustomerFirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.CustomerLastname)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
