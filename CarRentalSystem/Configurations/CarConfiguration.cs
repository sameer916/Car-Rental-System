using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarRentalSystem.Models;
using System.Data.Entity.ModelConfiguration;

namespace CarRentalSystem.Configurations
{
    public class CarConfiguration:EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            ToTable("tbl_Car");

            HasKey(c => c.CarId);

            Property(c => c.CarName)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.CarType)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.DefaultPrice)
                .IsRequired();

            HasRequired(c => c.CarRental)
                .WithMany(r => r.RentalCarList)
                .HasForeignKey(c => c.RentalId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.CarOwner)
                .WithMany(o=>o.OwnerCarList)
                .HasForeignKey(c=>c.OwnerId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.CarAdmin)
                .WithMany(a => a.AdminCarList)
                .HasForeignKey(c => c.AdminId)
                .WillCascadeOnDelete(false);
        }
    }
}