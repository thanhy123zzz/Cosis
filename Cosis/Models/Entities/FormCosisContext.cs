using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cosis.Models.Entities
{
    public partial class FormCosisContext : DbContext
    {
        public FormCosisContext()
        {
        }

        public FormCosisContext(DbContextOptions<FormCosisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DanhSachNhanToAnhHuong> DanhSachNhanToAnhHuong { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<LoaiHinhKinhte> LoaiHinhKinhte { get; set; }
        public virtual DbSet<Master> Master { get; set; }
        public virtual DbSet<NganhHoatDongKinhDoanh> NganhHoatDongKinhDoanh { get; set; }
        public virtual DbSet<NganhKinhDoanh> NganhKinhDoanh { get; set; }
        public virtual DbSet<NhanToAnhHuong> NhanToAnhHuong { get; set; }
        public virtual DbSet<NhanToThu9> NhanToThu9 { get; set; }
        public virtual DbSet<PhuongXa> PhuongXa { get; set; }
        public virtual DbSet<QuanHuyen> QuanHuyen { get; set; }
        public virtual DbSet<ThongTinCaThe> ThongTinCaThe { get; set; }
        public virtual DbSet<ThongTinDoanhNghiep> ThongTinDoanhNghiep { get; set; }
        public virtual DbSet<TinhTp> TinhTp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-FPKNLS6A\\SQLEXPRESS;Initial Catalog= FormCosis;Persist Security Info=True;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhSachNhanToAnhHuong>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MaAh)
                    .HasColumnName("MaAH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MaAhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaAh)
                    .HasConstraintName("FK__DanhSachNh__MaAH__10216507");

                entity.HasOne(d => d.MaPhieuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaPhieu)
                    .HasConstraintName("FK__DanhSachN__MaPhi__0F2D40CE");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.MaPhieu, e.Stt })
                    .HasName("unique_Detail")
                    .IsUnique();

                entity.Property(e => e.DuTinh).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Dvt)
                    .HasColumnName("DVT")
                    .HasMaxLength(20);

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCt)
                    .HasColumnName("TenCT")
                    .HasMaxLength(100);

                entity.Property(e => e.ThthangTruoc)
                    .HasColumnName("THThangTruoc")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TongCongDon).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Tttm)
                    .HasColumnName("TTTM")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaPhieuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaPhieu)
                    .HasConstraintName("FK__Detail__MaPhieu__0B5CAFEA");
            });

            modelBuilder.Entity<LoaiHinhKinhte>(entity =>
            {
                entity.HasKey(e => e.MaLh)
                    .HasName("PK__LoaiHinh__2725C77F5F86CA89");

                entity.Property(e => e.MaLh)
                    .HasColumnName("MaLH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenLh)
                    .HasColumnName("TenLH")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__Master__2660BFE0F12FB40D");

                entity.HasIndex(e => new { e.MaSoThue, e.MaSoThue2, e.MaCoSo, e.NgayThucHien, e.NgayDuTinh })
                    .HasName("unique_Master")
                    .IsUnique();

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCoSo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaLh)
                    .HasColumnName("MaLH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NgayDuTinh).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NgayThucHien).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdtnguoiTraLoi)
                    .HasColumnName("SDTNguoiTraLoi")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ten).HasMaxLength(200);

                entity.Property(e => e.TenNguoiTraLoi).HasMaxLength(50);

                entity.HasOne(d => d.MaCoSoNavigation)
                    .WithMany(p => p.Master)
                    .HasForeignKey(d => d.MaCoSo)
                    .HasConstraintName("FK__Master__MaCoSo__03BB8E22");

                entity.HasOne(d => d.MaLhNavigation)
                    .WithMany(p => p.Master)
                    .HasForeignKey(d => d.MaLh)
                    .HasConstraintName("FK__Master__MaLH__02C769E9");

                entity.HasOne(d => d.MaSoThueNavigation)
                    .WithMany(p => p.Master)
                    .HasForeignKey(d => new { d.MaSoThue, d.MaSoThue2 })
                    .HasConstraintName("FK__Master__04AFB25B");
            });

            modelBuilder.Entity<NganhHoatDongKinhDoanh>(entity =>
            {
                entity.HasKey(e => e.MaNganh)
                    .HasName("PK__NganhHoa__A2CEF50D56126D5A");

                entity.Property(e => e.MaNganh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenNganh).HasMaxLength(250);
            });

            modelBuilder.Entity<NganhKinhDoanh>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MaCoSo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaNganh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MaCoSoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaCoSo)
                    .HasConstraintName("FK__NganhKinh__MaCoS__0880433F");

                entity.HasOne(d => d.MaNganhNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaNganh)
                    .HasConstraintName("FK__NganhKinh__MaNga__078C1F06");

                entity.HasOne(d => d.MaSoThueNavigation)
                    .WithMany()
                    .HasForeignKey(d => new { d.MaSoThue, d.MaSoThue2 })
                    .HasConstraintName("FK__NganhKinhDoanh__0697FACD");
            });

            modelBuilder.Entity<NhanToAnhHuong>(entity =>
            {
                entity.HasKey(e => e.MaAh)
                    .HasName("PK__NhanToAn__27247E42311A4AB2");

                entity.Property(e => e.MaAh)
                    .HasColumnName("MaAH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoiDungAh)
                    .HasColumnName("NoiDungAH")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NhanToThu9>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MaPhieu)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoiDung).HasMaxLength(200);

                entity.HasOne(d => d.MaPhieuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaPhieu)
                    .HasConstraintName("FK__NhanToThu__MaPhi__1209AD79");
            });

            modelBuilder.Entity<PhuongXa>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Level).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<QuanHuyen>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<ThongTinCaThe>(entity =>
            {
                entity.HasKey(e => e.MaCoSo)
                    .HasName("PK__ThongTin__152D063440D6961C");

                entity.Property(e => e.MaCoSo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaLh)
                    .HasColumnName("MaLH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdtcoSo)
                    .HasColumnName("SDTCoSo")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCoSo).HasMaxLength(200);

                entity.HasOne(d => d.MaLhNavigation)
                    .WithMany(p => p.ThongTinCaThe)
                    .HasForeignKey(d => d.MaLh)
                    .HasConstraintName("FK__ThongTinCa__MaLH__662B2B3B");
            });

            modelBuilder.Entity<ThongTinDoanhNghiep>(entity =>
            {
                entity.HasKey(e => new { e.MaSoThue, e.MaSoThue2 })
                    .HasName("PK__ThongTin__E1639B2C051B2A2B");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaLh)
                    .HasColumnName("MaLH")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SdtdoanhNghiep)
                    .HasColumnName("SDTDoanhNghiep")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenDoanhNghiep).HasMaxLength(200);

                entity.HasOne(d => d.MaLhNavigation)
                    .WithMany(p => p.ThongTinDoanhNghiep)
                    .HasForeignKey(d => d.MaLh)
                    .HasConstraintName("FK__ThongTinDo__MaLH__634EBE90");
            });

            modelBuilder.Entity<TinhTp>(entity =>
            {
                entity.ToTable("TinhTP");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
