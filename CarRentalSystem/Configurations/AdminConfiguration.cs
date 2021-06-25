using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarRentalSystem.Models;
using System.Data.Entity.ModelConfiguration;

namespace CarRentalSystem.Configurations
{
    public class AdminConfiguration:EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            ToTable("tbl_Admin");

            HasKey(a => a.AdminId);

            Property(a => a.AdminName)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.Address)
                .HasMaxLength(300);

            Property(a => a.PhoneNumber)
                .IsRequired();


            Property(a => a.EmailId)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Password)
                .IsRequired();

            
        }
    }
}