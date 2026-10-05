using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyHoiVien.Models;

public partial class QuanLyHoiVienContext : DbContext
{
    public QuanLyHoiVienContext()
    {
    }

    public QuanLyHoiVienContext(DbContextOptions<QuanLyHoiVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HoiVien> HoiViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=QuanLyHoiVien;User Id=sa;Password=SuperPass@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HoiVien>(entity =>
        {
            entity.HasKey(e => e.MaHv).HasName("PK__HoiVien__2725A6D25C606C45");

            entity.ToTable("HoiVien");

            entity.Property(e => e.MaHv).HasColumnName("MaHV");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HangThanhVien).HasMaxLength(20);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.NgayDangKy)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
