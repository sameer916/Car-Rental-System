using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarRentalSystem.Models;
using System.Data.Entity.ModelConfiguration;

namespace CarRentalSystem.Configurations
{
    public class RentalConfiguration : EntityTypeConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            ToTable("tbl_Rental");

            HasKey(r => r.RentalId);

            Property(r => r.PickupDate)
                .IsRequired();

            Property(r => r.ReturnDate)
                .IsRequired();

            Property(r => r.Source)
                .HasMaxLength(255)
                .IsRequired();

            Property(r => r.Destination)
                .HasMaxLength(255)
                .IsRequired();

            Property(r => r.FairAmount)
                .IsRequired();

            Property(r => r.InitialFuel)
                .HasMaxLength(255)
                .IsRequired();

            HasRequired(r => r.RentalAdmin)
                .WithMany(a => a.AdminRentalList)
                .HasForeignKey(r => r.AdminId)
                .WillCascadeOnDelete(false);
        }
        
    }
}