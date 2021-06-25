using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CarRentalSystem.Models;
using System.Data.Entity.ModelConfiguration;

namespace CarRentalSystem.Configurations
{
    public class OwnerConfiguration: EntityTypeConfiguration<Owner>
    {
        public OwnerConfiguration()
        {
            ToTable("tbl_Owner");

            HasKey(o => o.OwnerId);

            Property(o => o.OwnerName)
                .IsRequired()
                .HasMaxLength(50);

            Property(o => o.Address)
                .IsRequired()
                .HasMaxLength(300);

            Property(o => o.PhoneNumber)
                .IsRequired();
            
            Property(o => o.EmailId)
                .IsRequired()
                .HasMaxLength(100);
            
            Property(o => o.Password)
                .IsRequired();

            HasRequired(o => o.OwnerAdmin)
                .WithMany(a => a.AdminOwnerList)
                .HasForeignKey(o => o.AdminId)
                .WillCascadeOnDelete(false);
        }
    }
}