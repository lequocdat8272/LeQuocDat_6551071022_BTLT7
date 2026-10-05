using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyLichKhamBenh.Models;

public partial class QuanLyLichKhamBenhContext : DbContext
{
    public QuanLyLichKhamBenhContext()
    {
    }

    public QuanLyLichKhamBenhContext(DbContextOptions<QuanLyLichKhamBenhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BacSi> BacSis { get; set; }

    public virtual DbSet<LichKham> LichKhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=QuanLyLichKhamBenh;User Id=sa;Password=SuperPass@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BacSi>(entity =>
        {
            entity.HasKey(e => e.MaBs).HasName("PK__BacSi__27247596C73A4A80");

            entity.ToTable("BacSi");

            entity.Property(e => e.MaBs).HasColumnName("MaBS");
            entity.Property(e => e.ChuyenKhoa).HasMaxLength(100);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<LichKham>(entity =>
        {
            entity.HasKey(e => e.MaLich).HasName("PK__LichKham__728A9AE98B808381");

            entity.ToTable("LichKham");

            entity.Property(e => e.GioKham).HasMaxLength(10);
            entity.Property(e => e.MaBs).HasColumnName("MaBS");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenBenhNhan).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasMaxLength(20);

            entity.HasOne(d => d.MaBsNavigation).WithMany(p => p.LichKhams)
                .HasForeignKey(d => d.MaBs)
                .HasConstraintName("FK__LichKham__MaBS__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
