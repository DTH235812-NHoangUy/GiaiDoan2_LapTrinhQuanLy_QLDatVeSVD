namespace LapTrinhQuanLy_QuanLyDatVeSVD.Forms
{
    partial class frmGheNgoi
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
            dgvGheNgoi = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSoGhe = new DataGridViewTextBoxColumn();
            colLoaiGhe = new DataGridViewTextBoxColumn();
            colGiaTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewCheckBoxColumn();
            grpThongTin = new GroupBox();
            chkTrangThai = new CheckBox();
            lblGiaTien = new Label();
            txtGiaTien = new TextBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblSoGhe = new Label();
            txtSoGhe = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGheNgoi).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvGheNgoi);
            groupBox2.Location = new Point(12, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 263);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Ghế ngồi";
            // 
            // dgvGheNgoi
            // 
            dgvGheNgoi.AllowUserToAddRows = false;
            dgvGheNgoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGheNgoi.BackgroundColor = Color.White;
            dgvGheNgoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGheNgoi.Columns.AddRange(new DataGridViewColumn[] { colID, colSoGhe, colLoaiGhe, colGiaTien, colTrangThai });
            dgvGheNgoi.Dock = DockStyle.Fill;
            dgvGheNgoi.Location = new Point(3, 19);
            dgvGheNgoi.Name = "dgvGheNgoi";
            dgvGheNgoi.ReadOnly = true;
            dgvGheNgoi.RowHeadersVisible = false;
            dgvGheNgoi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGheNgoi.Size = new Size(770, 241);
            dgvGheNgoi.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colSoGhe
            // 
            colSoGhe.HeaderText = "Số Ghế";
            colSoGhe.Name = "colSoGhe";
            colSoGhe.ReadOnly = true;
            // 
            // colLoaiGhe
            // 
            colLoaiGhe.HeaderText = "Loại Ghế";
            colLoaiGhe.Name = "colLoaiGhe";
            colLoaiGhe.ReadOnly = true;
            // 
            // colGiaTien
            // 
            colGiaTien.HeaderText = "Giá Tiền";
            colGiaTien.Name = "colGiaTien";
            colGiaTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Đã đặt";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(chkTrangThai);
            grpThongTin.Controls.Add(lblGiaTien);
            grpThongTin.Controls.Add(txtGiaTien);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(lblSoGhe);
            grpThongTin.Controls.Add(txtSoGhe);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(776, 157);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Ghế ngồi";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkTrangThai.ForeColor = Color.Blue;
            chkTrangThai.Location = new Point(540, 42);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(120, 19);
            chkTrangThai.TabIndex = 2;
            chkTrangThai.Text = "Trạng thái đã đặt";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Location = new Point(278, 43);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(50, 15);
            lblGiaTien.TabIndex = 3;
            lblGiaTien.Text = "Giá tiền:";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(356, 40);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(150, 23);
            txtGiaTien.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightCoral;
            btnThoat.Location = new Point(609, 115);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 30);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(401, 115);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 30);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(508, 115);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 30);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(297, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(194, 115);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 30);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(85, 115);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // lblSoGhe
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Location = new Point(20, 43);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(46, 15);
            lblSoGhe.TabIndex = 9;
            lblSoGhe.Text = "Số ghế:";
            // 
            // txtSoGhe
            // 
            txtSoGhe.Location = new Point(85, 40);
            txtSoGhe.Name = "txtSoGhe";
            txtSoGhe.Size = new Size(150, 23);
            txtSoGhe.TabIndex = 0;
            // 
            // frmGheNgoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grpThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGheNgoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Ghế ngồi ";
            Load += frmGheNgoi_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGheNgoi).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvGheNgoi;
        private GroupBox grpThongTin;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblSoGhe;
        private TextBox txtSoGhe;
        private Label lblGiaTien;
        private TextBox txtGiaTien;
        private CheckBox chkTrangThai;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSoGhe;
        private DataGridViewTextBoxColumn colLoaiGhe;
        private DataGridViewTextBoxColumn colGiaTien;
        private DataGridViewCheckBoxColumn colTrangThai;
    }
}