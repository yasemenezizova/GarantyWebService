using BankOperation.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation.Data.Concrete.Mappings
{
    public class BankMapping : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> entity)
        {
            entity.HasKey(e => e.Id).HasName("BANKS_pkey");

            entity.ToTable("BANKS", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 999999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.CodeN).HasColumnName("CODE_N");
            entity.Property(e => e.Fax).HasColumnName("FAX");
            entity.Property(e => e.FullName).HasColumnName("FULL_NAME");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERT_DATE");
            entity.Property(e => e.InsertUserId).HasColumnName("INSERT_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.ShortName).HasColumnName("SHORT_NAME");
            entity.Property(e => e.Swift).HasColumnName("SWIFT");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Voen).HasColumnName("VOEN");
        }
    }
}
