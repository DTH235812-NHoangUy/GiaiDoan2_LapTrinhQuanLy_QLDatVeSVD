using System;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string TenNhanVien { get; set; }
        public string SoDienThoai { get; set; }

        // Dùng để đăng nhập
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        // Phân quyền: ví dụ "Admin" hoặc "Staff"
        public string VaiTro { get; set; }
    }
}