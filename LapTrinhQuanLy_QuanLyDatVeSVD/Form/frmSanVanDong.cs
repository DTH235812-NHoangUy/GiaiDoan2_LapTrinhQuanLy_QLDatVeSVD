using LapTrinhQuanLy_QuanLyDatVeSVD.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    public partial class frmSanVanDong : System.Windows.Forms.Form
    {
        public frmSanVanDong()
        {
            InitializeComponent();
        }

        // Đã sửa: Đổi QuanLySVDDbContext thành AppDbContext cho khớp với file Data của bạn
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenSan.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtSucChua.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmSanVanDong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            try
            {
                // 1. Load dữ liệu từ Database
                var listSVD = context.SanVanDong.ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = listSVD;

                // 2. Cấu hình DataGridView
                dgvSanVanDong.AutoGenerateColumns = false;
                dgvSanVanDong.DataSource = bindingSource;

                // Ánh xạ thuộc tính (Lưu ý: "colID", "colTenSan"... phải trùng với name bạn đặt trong Designer)
                if (dgvSanVanDong.Columns.Contains("colID")) dgvSanVanDong.Columns["colID"].DataPropertyName = "ID";
                if (dgvSanVanDong.Columns.Contains("colTenSan")) dgvSanVanDong.Columns["colTenSan"].DataPropertyName = "TenSanVanDong";
                if (dgvSanVanDong.Columns.Contains("colDiaChi")) dgvSanVanDong.Columns["colDiaChi"].DataPropertyName = "DiaChi";
                if (dgvSanVanDong.Columns.Contains("colSucChua")) dgvSanVanDong.Columns["colSucChua"].DataPropertyName = "SucChua";

                // 3. Data Binding cho các TextBox
                txtTenSan.DataBindings.Clear();
                txtTenSan.DataBindings.Add("Text", bindingSource, "TenSanVanDong", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                txtSucChua.DataBindings.Clear();
                txtSucChua.DataBindings.Add("Text", bindingSource, "SucChua", false, DataSourceUpdateMode.Never);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                xuLyThem = true;
                BatTatChucNang(true);
                txtTenSan.Clear();
                txtDiaChi.Clear();
                txtSucChua.Clear();
                txtTenSan.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                if (dgvSanVanDong.CurrentRow != null)
                {
                    xuLyThem = false;
                    BatTatChucNang(true);
                    id = Convert.ToInt32(dgvSanVanDong.CurrentRow.Cells["colID"].Value);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (dgvSanVanDong.CurrentRow != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(dgvSanVanDong.CurrentRow.Cells["colID"].Value);
                        var svd = context.SanVanDong.Find(id);
                        if (svd != null)
                        {
                            context.SanVanDong.Remove(svd);
                            context.SaveChanges();
                        }
                        frmSanVanDong_Load(sender, e);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtTenSan.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (xuLyThem)
                {
                    SanVanDong svdMoi = new SanVanDong
                    {
                        TenSanVanDong = txtTenSan.Text,
                        DiaChi = txtDiaChi.Text,
                        SucChua = int.TryParse(txtSucChua.Text, out int sc) ? sc : 0
                    };
                    context.SanVanDong.Add(svdMoi);
                }
                else
                {
                    var svdSua = context.SanVanDong.Find(id);
                    if (svdSua != null)
                    {
                        svdSua.TenSanVanDong = txtTenSan.Text;
                        svdSua.DiaChi = txtDiaChi.Text;
                        svdSua.SucChua = int.TryParse(txtSucChua.Text, out int sc) ? sc : 0;
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Thành công!", "Thông báo");
                frmSanVanDong_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanVanDong_Load(sender, e);
        }
    }
}