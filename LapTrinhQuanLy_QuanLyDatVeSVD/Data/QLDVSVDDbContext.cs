using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Data
{
    public class AppDbContext : DbContext
    {
        // Khởi tạo các bảng (DbSet) tương ứng với 8 Model đã viết
        public DbSet<SanVanDong> SanVanDong { get; set; }
        public DbSet<KhuVuc> KhuVuc { get; set; }
        public DbSet<GheNgoi> GheNgoi { get; set; }
        public DbSet<SuKien> SuKien { get; set; }
        public DbSet<LoaiVe> LoaiVe { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDonVe> HoaDonVe { get; set; }
        public DbSet<ChiTietVe> ChiTietVe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Lấy chuỗi kết nối "QLBHConnection" từ file App.config
                string connectionString = ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString;

                // Cấu hình sử dụng SQL Server
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}