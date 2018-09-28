using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppListDal.Model
{
    public partial class AppListContext : DbContext
    {
        public AppListContext()
        {
        }

        public AppListContext(DbContextOptions<AppListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationList> ApplicationList { get; set; }
        public virtual DbSet<Arch> Arch { get; set; }
        public virtual DbSet<InfraSlas> InfraSlas { get; set; }
        public virtual DbSet<SecurityCompliance> SecurityCompliance { get; set; }
        public virtual DbSet<Strategy> Strategy { get; set; }
        public virtual DbSet<TbleColumn> TbleColumn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;;Database=AppList;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Server=CLAYDS0992LT\\ADOITCE;Database=AppList;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Arch)
                    .HasForeignKey<Arch>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arch_ToTable");
            });

            modelBuilder.Entity<InfraSlas>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InfraSlas)
                    .HasForeignKey<InfraSlas>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfraSLAs_ToTable");
            });

            modelBuilder.Entity<SecurityCompliance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.SecurityCompliance)
                    .HasForeignKey<SecurityCompliance>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecurityCompliance_ToTable");
            });

            modelBuilder.Entity<Strategy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Strategy)
                    .HasForeignKey<Strategy>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Strategy_ToTable");
            });
        }
    }
}
