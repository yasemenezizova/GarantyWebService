using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankOperation.Entity.Concretes;

public partial class GarantydbContext : DbContext
{
    public GarantydbContext()
    {
    }

    public GarantydbContext(DbContextOptions<GarantydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankGuarantee> BankGuarantees { get; set; }

    public virtual DbSet<BankGuaranteeOperation> BankGuaranteeOperations { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Custom> Customs { get; set; }

    public virtual DbSet<CustomsGuarantee> CustomsGuarantees { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Guarantee> Guarantees { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleGroup> RoleGroups { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=217.76.63.20;Port=6432;Database=garantydb;Username=garanty;Password=internCustoms123!;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>(entity =>
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
        });
        //
        modelBuilder.Entity<BankGuarantee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("BANK_GUARANTEES_pkey");

            entity.ToTable("BANK_GUARANTEES", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 999999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.UpdatesDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATES_DATE");

            entity.HasOne(d => d.Bank).WithMany(p => p.BankGuarantees)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK_BANKS");

            entity.HasOne(d => d.Company).WithMany(p => p.BankGuarantees)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_COMPANIES");
        });

        modelBuilder.Entity<BankGuaranteeOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("BANK_GUARANTEE_OPERATION_pkey");

            entity.ToTable("BANK_GUARANTEE_OPERATION", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 999999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.GuaranteeId).HasColumnName("GUARANTEE_ID");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");
            entity.Property(e => e.UsedLimit).HasColumnName("USED_LIMIT");

            entity.HasOne(d => d.Guarantee).WithMany(p => p.BankGuaranteeOperations)
                .HasForeignKey(d => d.GuaranteeId)
                .HasConstraintName("FK_GUARANTEES");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("COMPANIES_pkey");

            entity.ToTable("COMPANIES", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
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
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Voen).HasColumnName("VOEN");
        });

        modelBuilder.Entity<Custom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CUSTOMS_pkey");

            entity.ToTable("CUSTOMS", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Adress).HasColumnName("ADRESS");
            entity.Property(e => e.Border).HasColumnName("BORDER");
            entity.Property(e => e.CodeN).HasColumnName("CODE_N");
            entity.Property(e => e.Fax).HasColumnName("FAX");
            entity.Property(e => e.FullName).HasColumnName("FULL_NAME");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERT_DATE");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.ShortName).HasColumnName("SHORT_NAME");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Voen).HasColumnName("VOEN");
        });

        modelBuilder.Entity<CustomsGuarantee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CUSTOMS_GUARANTEES_pkey");

            entity.ToTable("CUSTOMS_GUARANTEES", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.CustomsId).HasColumnName("CUSTOMS_ID");
            entity.Property(e => e.GuaranteeId).HasColumnName("GUARANTEE_ID");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");

            entity.HasOne(d => d.Customs).WithMany(p => p.CustomsGuarantees)
                .HasForeignKey(d => d.CustomsId)
                .HasConstraintName("FK_CUSTOMS");

            entity.HasOne(d => d.Guarantee).WithMany(p => p.CustomsGuarantees)
                .HasForeignKey(d => d.GuaranteeId)
                .HasConstraintName("FK_GUARANTEES");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GROUPS_pkey");

            entity.ToTable("GROUPS", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnName("NAME");
        });

        modelBuilder.Entity<Guarantee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GUARANTEES_pkey");

            entity.ToTable("GUARANTEES", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.BankGuaranteesId).HasColumnName("BANK_GUARANTEES_ID");
            entity.Property(e => e.DueDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("DUE_DATE");
            entity.Property(e => e.FileId).HasColumnName("FILE_ID");
            entity.Property(e => e.GuaranteeNo).HasColumnName("GUARANTEE_NO");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Limit).HasColumnName("LIMIT");
            entity.Property(e => e.RemainingLimit).HasColumnName("REMAINING_LIMIT");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");

            entity.HasOne(d => d.BankGuarantees).WithMany(p => p.Guarantees)
                .HasForeignKey(d => d.BankGuaranteesId)
                .HasConstraintName("FK_BANK_GUARANTEES");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ROLES_pkey");

            entity.ToTable("ROLES", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");
        });

        modelBuilder.Entity<RoleGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ROLE_GROUP_pkey");

            entity.ToTable("ROLE_GROUP", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.CanDelete).HasColumnName("CAN_DELETE");
            entity.Property(e => e.CanEdit).HasColumnName("CAN_EDIT");
            entity.Property(e => e.CanExport).HasColumnName("CAN_EXPORT");
            entity.Property(e => e.CanInsert).HasColumnName("CAN_INSERT");
            entity.Property(e => e.CanView).HasColumnName("CAN_VIEW");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");

            entity.HasOne(d => d.Group).WithMany(p => p.RoleGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_GROUPS");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleGroups)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_ROLES");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("USERS_pkey");

            entity.ToTable("USERS", "GUARANTEE");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 99999999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");
            entity.Property(e => e.CustomId).HasColumnName("CUSTOM_ID");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
            entity.Property(e => e.InsertedDate)
                .HasDefaultValueSql("CURRENT_DATE")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("INSERTED_DATE");
            entity.Property(e => e.InsertedUserId).HasColumnName("INSERTED_USER_ID");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("true")
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.LastLoginDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("LAST_LOGIN_DATE");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Password).HasColumnName("PASSWORD");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.Surname).HasColumnName("SURNAME");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("UPDATED_DATE");
            entity.Property(e => e.UserGuid).HasColumnName("USER_GUID");

            entity.HasOne(d => d.Bank).WithMany(p => p.Users)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("FK_BANKS");

            entity.HasOne(d => d.Company).WithMany(p => p.Users)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_COMPANIES");

            entity.HasOne(d => d.Custom).WithMany(p => p.Users)
                .HasForeignKey(d => d.CustomId)
                .HasConstraintName("FK_CUSTOMS");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_ROLES");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
