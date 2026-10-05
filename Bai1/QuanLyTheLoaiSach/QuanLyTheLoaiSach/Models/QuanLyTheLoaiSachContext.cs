using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyTheLoaiSach.Models;

public partial class QuanLyTheLoaiSachContext : DbContext
{
    public QuanLyTheLoaiSachContext()
    {
    }

    public QuanLyTheLoaiSachContext(DbContextOptions<QuanLyTheLoaiSachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TheLoaiSach> TheLoaiSaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=QuanLyTheLoaiSach;User Id=sa;Password=SuperPass@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TheLoaiSach>(entity =>
        {
            entity.HasKey(e => e.MaTl).HasName("PK__TheLoaiS__27250071D429B7D7");

            entity.ToTable("TheLoaiSach");

            entity.HasIndex(e => e.TenTheLoai, "UQ__TheLoaiS__327F958F78CC428D").IsUnique();

            entity.Property(e => e.MaTl).HasColumnName("MaTL");
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SoLuongSach).HasDefaultValue(0);
            entity.Property(e => e.TenTheLoai).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
