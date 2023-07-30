using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ManageSystem.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model3")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<CHITIETBANGCHAMCONG> CHITIETBANGCHAMCONGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<QUANLYDON> QUANLYDONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<BANGLUONG>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.BANGLUONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETBANGCHAMCONG>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETBANGCHAMCONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QUANLYDON>()
                .Property(e => e.MANV)
                .IsUnicode(false);
        }
    }
}
