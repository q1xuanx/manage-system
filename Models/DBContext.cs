using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ManageSystem.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BANGCHAMCONG> BANGCHAMCONGs { get; set; }
        public virtual DbSet<BANGLUONG> BANGLUONGs { get; set; }
        public virtual DbSet<CHITIETBANGCHAMCONG> CHITIETBANGCHAMCONGs { get; set; }
        public virtual DbSet<CHITIETBANGLUONG> CHITIETBANGLUONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<TRINHDOHOCVAN> TRINHDOHOCVANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<BANGCHAMCONG>()
                .HasMany(e => e.CHITIETBANGCHAMCONGs)
                .WithRequired(e => e.BANGCHAMCONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANGCHAMCONG>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.BANGCHAMCONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANGLUONG>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.BANGLUONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIETBANGCHAMCONG>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETBANGLUONG>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETBANGCHAMCONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHITIETBANGLUONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGBAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.PHONGBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRINHDOHOCVAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.TRINHDOHOCVAN)
                .WillCascadeOnDelete(false);
        }
    }
}
