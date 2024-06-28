using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp2
{
    public partial class BCcontext : DbContext
    {
        public BCcontext()
            : base("name=BCcontext")
        {
        }

        public virtual DbSet<Diem_HS> Diem_HS { get; set; }
        public virtual DbSet<H_KY> H_KY { get; set; }
        public virtual DbSet<HSinh> HSinhs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem_HS>()
                .Property(e => e.idHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<Diem_HS>()
                .Property(e => e.idMonHoc)
                .IsUnicode(false);

            modelBuilder.Entity<Diem_HS>()
                .Property(e => e.idHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<H_KY>()
                .Property(e => e.idHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<HSinh>()
                .Property(e => e.idHocSinh)
                .IsUnicode(false);

            modelBuilder.Entity<HSinh>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<HSinh>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HSinh>()
                .Property(e => e.STT)
                .IsUnicode(false);

            modelBuilder.Entity<HSinh>()
                .HasMany(e => e.Diem_HS)
                .WithRequired(e => e.HSinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.IdLop)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.IdGVCN)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.Khoi)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.Truong_MH)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.Diem_HS)
                .WithRequired(e => e.MONHOC)
                .HasForeignKey(e => e.idMonHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
