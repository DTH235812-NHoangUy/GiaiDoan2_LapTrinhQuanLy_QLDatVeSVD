using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LapTrinhQuanLy_QuanLyDatVeSVD.Data;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    public partial class frmSuKien : System.Windows.Forms.Form
    {
        public frmSuKien()
        {
            InitializeComponent();
        }

        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenSuKien.Enabled = giaTri;
            dtpNgayToChuc.Enabled = giaTri;
            cboSanVanDong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenSuKien.Clear();
            dtpNgayToChuc.Value = DateTime.Now;
            cboSanVanDong.SelectedIndex = -1; // Để trống combo khi thêm mới
            txtTenSuKien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSuKien.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvSuKien.CurrentRow.Cells["colID"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSuKien.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sự kiện này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvSuKien.CurrentRow.Cells["colID"].Value);
                    var sk = context.SuKien.Find(id);
                    if (sk != null)
                    {
                        context.SuKien.Remove(sk);
                        context.SaveChanges();
                    }
                    frmSuKien_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSuKien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sự kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSanVanDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sân vận động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    SuKien skMoi = new SuKien
                    {
                        TenSuKien = txtTenSuKien.Text,
                        NgayToChuc = dtpNgayToChuc.Value,
                        // Lưu trực tiếp Tên sân (string) vào CSDL
                        SanVanDongID = cboSanVanDong.SelectedValue.ToString()
                    };
                    context.SuKien.Add(skMoi);
                }
                else
                {
                    var skSua = context.SuKien.Find(id);
                    if (skSua != null)
                    {
                        skSua.TenSuKien = txtTenSuKien.Text;
                        skSua.NgayToChuc = dtpNgayToChuc.Value;
                        skSua.SanVanDongID = cboSanVanDong.SelectedValue.ToString();
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                frmSuKien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSuKien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuKien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            try
            {
                // 1. Cấu hình ComboBox để lấy Tên làm giá trị
                var listSVD = context.SanVanDong.ToList();
                cboSanVanDong.DataSource = listSVD;
                cboSanVanDong.DisplayMember = "TenSanVanDong";
                cboSanVanDong.ValueMember = "TenSanVanDong"; // Lấy tên làm giá trị thực

                // 2. Load danh sách Sự kiện
                var listSK = context.SuKien.ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = listSK;

                dgvSuKien.AutoGenerateColumns = false;
                dgvSuKien.DataSource = bindingSource;

                // Ánh xạ cột DataGridView (Sẽ hiển thị Tên vì SanVanDongID hiện là string chứa tên)
                if (dgvSuKien.Columns.Contains("colID"))
                    dgvSuKien.Columns["colID"].DataPropertyName = "ID";
                if (dgvSuKien.Columns.Contains("colTenSuKien"))
                    dgvSuKien.Columns["colTenSuKien"].DataPropertyName = "TenSuKien";
                if (dgvSuKien.Columns.Contains("colNgayToChuc"))
                    dgvSuKien.Columns["colNgayToChuc"].DataPropertyName = "NgayToChuc";
                if (dgvSuKien.Columns.Contains("colSanVanDong"))
                    dgvSuKien.Columns["colSanVanDong"].DataPropertyName = "SanVanDongID";

                // 3. Data Binding đồng bộ dữ liệu khi chọn dòng trên lưới
                txtTenSuKien.DataBindings.Clear();
                txtTenSuKien.DataBindings.Add("Text", bindingSource, "TenSuKien", false, DataSourceUpdateMode.Never);

                dtpNgayToChuc.DataBindings.Clear();
                dtpNgayToChuc.DataBindings.Add("Value", bindingSource, "NgayToChuc", false, DataSourceUpdateMode.Never);

                cboSanVanDong.DataBindings.Clear();
                cboSanVanDong.DataBindings.Add("SelectedValue", bindingSource, "SanVanDongID", false, DataSourceUpdateMode.Never);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}