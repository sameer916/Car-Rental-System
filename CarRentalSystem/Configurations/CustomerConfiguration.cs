using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarRentalSystem.Models;
using System.Data.Entity.ModelConfiguration;

namespace CarRentalSystem.Configurations
{
    public class CustomerConfiguration:EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("tbl_Customer");

            HasKey(c => c.CustomerId);

            Property(a => a.CustomerName)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(300);

            Property(c => c.PhoneNumber)
                .IsRequired();

            Property(c => c.EmailId)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Password)
                .IsRequired();

            HasRequired(c => c.CustomerAdmin)
                .WithMany(a => a.AdminCustomerList)
                .HasForeignKey(c => c.AdminId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.CustomerRental)
                .WithMany(r => r.RentalCustomerList)
                .HasForeignKey(c=>c.RentalId)
                .WillCascadeOnDelete(false);
        }
        
    }
}