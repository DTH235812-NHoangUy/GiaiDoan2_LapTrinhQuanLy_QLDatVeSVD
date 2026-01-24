using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    partial class frmKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            grpThongTin = new GroupBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colHoTen, colSoDienThoai, colEmail });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 19);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(770, 236);
            dgvKhachHang.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.Name = "colHoTen";
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.HeaderText = "Số Điện Thoại";
            colSoDienThoai.Name = "colSoDienThoai";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblSoDienThoai);
            grpThongTin.Controls.Add(txtSoDienThoai);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(776, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Khách hàng";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(380, 30);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(486, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Location = new Point(20, 65);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 23);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(125, 65);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(250, 23);
            txtSoDienThoai.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(600, 105);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Green;
            btnLuu.Location = new Point(400, 105);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
         
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(500, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy";
           
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(300, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
           
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            
            // 
            // btnThem
            // 
            btnThem.Location = new Point(100, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(20, 30);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 10;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 23);
            txtHoTen.TabIndex = 11;
            // 
            // frmKhachHang
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpThongTin);
            this.Name = "frmKhachHang";
            this.Text = "Quản lý Khách hàng";
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvKhachHang;
        private GroupBox grpThongTin;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblEmail;
        private TextBox txtEmail;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colEmail;
    }
}