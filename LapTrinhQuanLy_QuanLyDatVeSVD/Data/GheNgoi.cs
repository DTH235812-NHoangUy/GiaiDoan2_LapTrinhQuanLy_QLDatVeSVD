using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Data
{
    public class GheNgoi
    {
        public int ID { get; set; }
        public string SoGhe { get; set; }
        public int KhuVucID { get; set; }
        public bool TrangThai { get; set; } // Ví dụ: True là đã đặt, False là trống
    }
}