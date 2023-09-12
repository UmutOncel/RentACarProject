using Microsoft.EntityFrameworkCore;
using RentACar.Domain.Entities;
using RentACar.Infrastructure.Data.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Infrastructure.Data
{
    public class RentACarDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CASPER\SQL2022; Database=EFRentACar; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarCustomerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarParkTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CarParkFloorTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarCustomer> CarCustomers { get; set; }
        public virtual DbSet<CarPark> CarParks { get; set; }
        public virtual DbSet<CarParkFloor> CarParkFloors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
