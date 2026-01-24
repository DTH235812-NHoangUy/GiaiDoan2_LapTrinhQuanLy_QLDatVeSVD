using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LapTrinhQuanLy_QuanLyDatVeSVD.Data;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Forms
{
    public partial class frmGheNgoi : System.Windows.Forms.Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int idGheDangChon;

        public frmGheNgoi()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtSoGhe.Enabled = giaTri;
            txtGiaTien.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmGheNgoi_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Lấy dữ liệu từ bảng
                var queryList = context.GheNgoi.ToList();

                // Biến đổi dữ liệu sang định dạng hiển thị (Anonymous Object)
                var displayData = queryList.Select(g => new {
                    ID = g.ID,
                    SoGhe = g.SoGhe,
                    LoaiGheText = g.KhuVucID >= 200000 ? "VIP" : "Thường",
                    GiaTienHienThi = g.KhuVucID,
                    TrangThai = g.TrangThai
                }).ToList();

                // QUAN TRỌNG: Tắt tự động sinh cột và gán DataSource
                dgvGheNgoi.AutoGenerateColumns = false;
                dgvGheNgoi.DataSource = displayData;

                // Ánh xạ dữ liệu vào các cột thiết kế sẵn
                colID.DataPropertyName = "ID";
                colSoGhe.DataPropertyName = "SoGhe";
                colLoaiGhe.DataPropertyName = "LoaiGheText";
                colGiaTien.DataPropertyName = "GiaTienHienThi";
                colTrangThai.DataPropertyName = "TrangThai";

                // Định dạng hiển thị tiền tệ cho đẹp
                dgvGheNgoi.Columns["colGiaTien"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtSoGhe.Clear();
            txtGiaTien.Clear();
            chkTrangThai.Checked = false;
            txtSoGhe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGheNgoi.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);

                // Lấy ID từ dòng đang chọn
                idGheDangChon = (int)dgvGheNgoi.CurrentRow.Cells["colID"].Value;

                // Đổ dữ liệu lên các ô nhập
                txtSoGhe.Text = dgvGheNgoi.CurrentRow.Cells["colSoGhe"].Value.ToString();
                txtGiaTien.Text = dgvGheNgoi.CurrentRow.Cells["colGiaTien"].Value.ToString();
                chkTrangThai.Checked = (bool)dgvGheNgoi.CurrentRow.Cells["colTrangThai"].Value;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSoGhe.Text) || !int.TryParse(txtGiaTien.Text, out int giaNhap))
                {
                    MessageBox.Show("Vui lòng nhập đúng số ghế và giá tiền!");
                    return;
                }

                if (xuLyThem)
                {
                    GheNgoi g = new GheNgoi
                    {
                        SoGhe = txtSoGhe.Text,
                        KhuVucID = giaNhap, // Lưu giá vào KhuVucID
                        TrangThai = chkTrangThai.Checked
                    };
                    context.GheNgoi.Add(g);
                }
                else
                {
                    var g = context.GheNgoi.Find(idGheDangChon);
                    if (g != null)
                    {
                        g.SoGhe = txtSoGhe.Text;
                        g.KhuVucID = giaNhap;
                        g.TrangThai = chkTrangThai.Checked;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Đã lưu!");
                BatTatChucNang(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGheNgoi.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dgvGheNgoi.CurrentRow.Cells["colID"].Value;
                    var item = context.GheNgoi.Find(id);
                    if (item != null)
                    {
                        context.GheNgoi.Remove(item);
                        context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e) => BatTatChucNang(false);

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}