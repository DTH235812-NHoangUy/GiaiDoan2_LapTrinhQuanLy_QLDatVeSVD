namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    partial class frmSanVanDong
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
            dgvSanVanDong = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSan = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSucChua = new DataGridViewTextBoxColumn();
            grpThongTin = new GroupBox();
            lblSucChua = new Label();
            txtSucChua = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTenSan = new Label();
            txtTenSan = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSanVanDong);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Sân vận động";
            // 
            // dgvSanVanDong
            // 
            dgvSanVanDong.AllowUserToAddRows = false;
            dgvSanVanDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanVanDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanVanDong.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSan, colDiaChi, colSucChua });
            dgvSanVanDong.Dock = DockStyle.Fill;
            dgvSanVanDong.Location = new Point(3, 19);
            dgvSanVanDong.Name = "dgvSanVanDong";
            dgvSanVanDong.Size = new Size(770, 236);
            dgvSanVanDong.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colTenSan
            // 
            colTenSan.HeaderText = "Tên Sân Vận Động";
            colTenSan.Name = "colTenSan";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.Name = "colDiaChi";
            // 
            // colSucChua
            // 
            colSucChua.HeaderText = "Sức Chứa";
            colSucChua.Name = "colSucChua";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblSucChua);
            grpThongTin.Controls.Add(txtSucChua);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(lblTenSan);
            grpThongTin.Controls.Add(txtTenSan);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(776, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Sân vận động";
            // 
            // lblSucChua
            // 
            lblSucChua.Location = new Point(380, 30);
            lblSucChua.Name = "lblSucChua";
            lblSucChua.Size = new Size(100, 23);
            lblSucChua.TabIndex = 0;
            lblSucChua.Text = "Sức chứa:";
            // 
            // txtSucChua
            // 
            txtSucChua.Location = new Point(486, 27);
            txtSucChua.Name = "txtSucChua";
            txtSucChua.Size = new Size(150, 23);
            txtSucChua.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(20, 65);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(125, 65);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(250, 23);
            txtDiaChi.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(600, 105);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Green;
            btnLuu.Location = new Point(400, 105);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(500, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(300, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(100, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // lblTenSan
            // 
            lblTenSan.Location = new Point(20, 30);
            lblTenSan.Name = "lblTenSan";
            lblTenSan.Size = new Size(100, 23);
            lblTenSan.TabIndex = 10;
            lblTenSan.Text = "Tên sân:";
            // 
            // txtTenSan
            // 
            txtTenSan.Location = new Point(124, 27);
            txtTenSan.Name = "txtTenSan";
            txtTenSan.Size = new Size(250, 23);
            txtTenSan.TabIndex = 11;
            // 
            // frmSanVanDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grpThongTin);
            Name = "frmSanVanDong";
            Text = "Quản lý Sân vận động";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanVanDong).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvSanVanDong;
        private GroupBox grpThongTin;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblTenSan;
        private TextBox txtTenSan;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSucChua;
        private TextBox txtSucChua;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSan;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSucChua;
    }
}