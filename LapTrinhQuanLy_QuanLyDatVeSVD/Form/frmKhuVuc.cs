using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LapTrinhQuanLy_QuanLyDatVeSVD.Data; // Chứa AppDbContext và Model

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    public partial class frmKhuVuc : System.Windows.Forms.Form
    {
        private TextBox txtTenSan;
        private TextBox txtDiaChi;
        private TextBox txtSucChua;
        private DataGridView dgvSanVanDong;

        public frmKhuVuc()
        {
            InitializeComponent();

            txtTenSan = new TextBox();
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Location = new Point(20, 20); // Adjust location as needed
            this.Controls.Add(txtTenSan);

            txtDiaChi = new TextBox();
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Location = new Point(20, 60); // Adjust location as needed
            this.Controls.Add(txtDiaChi);

            txtSucChua = new TextBox();
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Location = new Point(20, 100); // Adjust location as needed
            this.Controls.Add(txtSucChua);

            dgvSanVanDong = new DataGridView();
            dgvSanVanDong.Name = "dgvSanVanDong";
            dgvSanVanDong.Location = new Point(20, 140); // Adjust location as needed
            dgvSanVanDong.Size = new Size(400, 200); // Adjust size as needed
            this.Controls.Add(dgvSanVanDong);
        }
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenKhuVuc.Enabled = giaTri;
            cboSanVanDong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void KhuVuc_Load(object sender, EventArgs e)
        {
            {
                BatTatChucNang(false);

                // 1. Load danh sách Sân Vận Động vào ComboBox
                var listSVD = context.SanVanDong.ToList();
                cboSanVanDong.DataSource = listSVD;
                cboSanVanDong.DisplayMember = "TenSanVanDong"; // Hiển thị tên sân
                cboSanVanDong.ValueMember = "ID";              // Giá trị lưu xuống là ID

                // 2. Load dữ liệu Khu Vực
                var listKhuVuc = context.KhuVuc.ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = listKhuVuc;

                // 3. Cấu hình DataGridView
                dgvKhuVuc.AutoGenerateColumns = false;
                dgvKhuVuc.DataSource = bindingSource;

                // Ánh xạ cột (đảm bảo tên cột colID, colTenKhuVuc... khớp với Designer)
                if (dgvKhuVuc.Columns.Contains("colID")) dgvKhuVuc.Columns["colID"].DataPropertyName = "ID";
                if (dgvKhuVuc.Columns.Contains("colTenKhuVuc")) dgvKhuVuc.Columns["colTenKhuVuc"].DataPropertyName = "TenKhuVuc";
                if (dgvKhuVuc.Columns.Contains("colTenSVD")) dgvKhuVuc.Columns["colTenSVD"].DataPropertyName = "SanVanDongID";

                // 4. Data Binding cho TextBox và ComboBox
                txtTenKhuVuc.DataBindings.Clear();
                txtTenKhuVuc.DataBindings.Add("Text", bindingSource, "TenKhuVuc", false, DataSourceUpdateMode.Never);

                cboSanVanDong.DataBindings.Clear();
                cboSanVanDong.DataBindings.Add("SelectedValue", bindingSource, "SanVanDongID", false, DataSourceUpdateMode.Never);
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
            if (dgvKhuVuc.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvKhuVuc.CurrentRow.Cells["colID"].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhuVuc.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa khu vực này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvKhuVuc.CurrentRow.Cells["colID"].Value);
                    var kv = context.KhuVuc.Find(id);
                    if (kv != null)
                    {
                        context.KhuVuc.Remove(kv);
                        context.SaveChanges();
                    }
                    KhuVuc_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhuVuc.Text) || cboSanVanDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (xuLyThem)
            {
                LapTrinhQuanLy_QuanLyDatVeSVD.Data.KhuVuc kvMoi = new LapTrinhQuanLy_QuanLyDatVeSVD.Data.KhuVuc();
                kvMoi.TenKhuVuc = txtTenKhuVuc.Text;
                kvMoi.SanVanDongID = (int)cboSanVanDong.SelectedValue;
                context.KhuVuc.Add(kvMoi);
            }
            else
            {
                var kvSua = context.KhuVuc.Find(id);
                if (kvSua != null)
                {
                    kvSua.TenKhuVuc = txtTenKhuVuc.Text;
                    kvSua.SanVanDongID = (int)cboSanVanDong.SelectedValue;
                    context.KhuVuc.Update(kvSua);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Lưu thành công!", "Thông báo");
            KhuVuc_Load(sender, e);
        }
        

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            KhuVuc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}