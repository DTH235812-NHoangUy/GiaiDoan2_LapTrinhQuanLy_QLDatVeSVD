using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Data
{
    public class SuKien
    {
        public int ID { get; set; }
        public string TenSuKien { get; set; }
        public DateTime NgayToChuc { get; set; }
        public int SanVanDongID { get; set; }
    }
}