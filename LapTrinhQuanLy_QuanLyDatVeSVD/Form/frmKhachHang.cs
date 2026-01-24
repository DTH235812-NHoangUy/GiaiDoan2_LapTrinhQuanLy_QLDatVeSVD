using LapTrinhQuanLy_QuanLyDatVeSVD.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    public partial class frmKhachHang : System.Windows.Forms.Form
    {
        public frmKhachHang()
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

            txtHoTen.Enabled = giaTri;
            txtSoDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                if (dgvKhachHang.CurrentRow != null)
                {
                    xuLyThem = false;
                    BatTatChucNang(true);
                    id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colID"].Value);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (dgvKhachHang.CurrentRow != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colID"].Value);
                        var kh = context.KhachHang.Find(id);
                        if (kh != null)
                        {
                            context.KhachHang.Remove(kh);
                            context.SaveChanges();
                        }
                        frmKhachHang_Load(sender, e);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    if (xuLyThem)
                    {
                        KhachHang khMoi = new KhachHang
                        {
                            HoTen = txtHoTen.Text,
                            SoDienThoai = txtSoDienThoai.Text,
                            Email = txtEmail.Text
                        };
                        context.KhachHang.Add(khMoi);
                    }
                    else
                    {
                        var khSua = context.KhachHang.Find(id);
                        if (khSua != null)
                        {
                            khSua.HoTen = txtHoTen.Text;
                            khSua.SoDienThoai = txtSoDienThoai.Text;
                            khSua.Email = txtEmail.Text;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                    frmKhachHang_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            {
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            {
                BatTatChucNang(false);

                try
                {
                    // 1. Load dữ liệu Khách hàng từ Database thông qua DbContext
                    var listKH = context.KhachHang.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = listKH;

                    // 2. Cấu hình DataGridView
                    dgvKhachHang.AutoGenerateColumns = false;
                    dgvKhachHang.DataSource = bindingSource;

                    // Ánh xạ thuộc tính (Hãy đảm bảo Name cột trong Designer khớp với các chuỗi này)
                    if (dgvKhachHang.Columns.Contains("colID")) dgvKhachHang.Columns["colID"].DataPropertyName = "ID";
                    if (dgvKhachHang.Columns.Contains("colHoTen")) dgvKhachHang.Columns["colHoTen"].DataPropertyName = "HoTen";
                    if (dgvKhachHang.Columns.Contains("colSoDienThoai")) dgvKhachHang.Columns["colSoDienThoai"].DataPropertyName = "SoDienThoai";
                    if (dgvKhachHang.Columns.Contains("colEmail")) dgvKhachHang.Columns["colEmail"].DataPropertyName = "Email";

                    // 3. Data Binding cho các TextBox (Khi click dòng trên lưới, Textbox tự đổi theo)
                    txtHoTen.DataBindings.Clear();
                    txtHoTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);

                    txtSoDienThoai.DataBindings.Clear();
                    txtSoDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

                    txtEmail.DataBindings.Clear();
                    txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}