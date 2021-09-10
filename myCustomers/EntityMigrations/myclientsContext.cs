using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myCustomers
{
    public partial class myclientsContext : DbContext
    {
        public myclientsContext()
        {
        }

        public myclientsContext(DbContextOptions<myclientsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CdCountry)
                    .HasName("PRIMARY");

                entity.ToTable("country");

                entity.Property(e => e.CdCountry)
                    .HasColumnName("cd_COUNTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.StCountryDescription)
                    .IsRequired()
                    .HasColumnName("st_COUNTRY_DESCRIPTION")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CdCustomer)
                    .HasName("PRIMARY");

                entity.ToTable("customer");

                entity.HasIndex(e => e.CdCountry)
                    .HasName("st_COUNTRY");

                entity.Property(e => e.CdCustomer).HasColumnName("cd_CUSTOMER");

                entity.Property(e => e.CdCountry)
                    .HasColumnName("cd_COUNTRY")
                    .HasMaxLength(2);

                entity.Property(e => e.DcBilling)
                    .HasColumnName("dc_BILLING")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ItAmount).HasColumnName("it_AMOUNT");

                entity.Property(e => e.StAddress)
                    .HasColumnName("st_ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.StCity)
                    .HasColumnName("st_CITY")
                    .HasMaxLength(100);

                entity.Property(e => e.StCnpj)
                    .IsRequired()
                    .HasColumnName("st_CNPJ")
                    .HasMaxLength(14);

                entity.Property(e => e.StDistrict)
                    .HasColumnName("st_DISTRICT")
                    .HasMaxLength(100);

                entity.Property(e => e.StMobile)
                    .IsRequired()
                    .HasColumnName("st_MOBILE")
                    .HasMaxLength(20);

                entity.Property(e => e.StName)
                    .IsRequired()
                    .HasColumnName("st_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.StOperation)
                    .HasColumnName("st_OPERATION")
                    .HasMaxLength(70);

                entity.Property(e => e.StPhone)
                    .HasColumnName("st_PHONE")
                    .HasMaxLength(20);

                entity.Property(e => e.StZipCode)
                    .HasColumnName("st_ZIP_CODE")
                    .HasMaxLength(8);

                entity.HasOne(d => d.CdCountryNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CdCountry)
                    .HasConstraintName("st_COUNTRY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
