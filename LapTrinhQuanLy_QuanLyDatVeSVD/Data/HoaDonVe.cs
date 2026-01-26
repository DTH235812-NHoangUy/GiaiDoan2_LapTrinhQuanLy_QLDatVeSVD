using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Data
{
    public class HoaDonVe
    {
        public int ID { get; set; }
        public DateTime NgayDat { get; set; }
        public int KhachHangID { get; set; }
        public int SuKienID { get; set; }
        public decimal TongTien { get; set; }
        public int NhanVienID { get; set; }
        public string TrangThaiThanhToan { get; set; }
    }
}