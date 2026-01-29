namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    partial class frmSuKien
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
            grpThongTin = new GroupBox();
            lblSanVanDong = new Label();
            cboSanVanDong = new ComboBox();
            lblNgayToChuc = new Label();
            dtpNgayToChuc = new DateTimePicker();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTenSuKien = new Label();
            txtTenSuKien = new TextBox();
            groupBox2 = new GroupBox();
            dgvSuKien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSuKien = new DataGridViewTextBoxColumn();
            colNgayToChuc = new DataGridViewTextBoxColumn();
            colSanVanDong = new DataGridViewTextBoxColumn();
            grpThongTin.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuKien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblSanVanDong);
            grpThongTin.Controls.Add(cboSanVanDong);
            grpThongTin.Controls.Add(lblNgayToChuc);
            grpThongTin.Controls.Add(dtpNgayToChuc);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(lblTenSuKien);
            grpThongTin.Controls.Add(txtTenSuKien);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(776, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Sự kiện";
            // 
            // lblSanVanDong
            // 
            lblSanVanDong.Location = new Point(400, 30);
            lblSanVanDong.Name = "lblSanVanDong";
            lblSanVanDong.Size = new Size(100, 23);
            lblSanVanDong.TabIndex = 0;
            lblSanVanDong.Text = "Sân vận động:";
            // 
            // cboSanVanDong
            // 
            cboSanVanDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanVanDong.Location = new Point(506, 27);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(200, 23);
            cboSanVanDong.TabIndex = 1;
            // 
            // lblNgayToChuc
            // 
            lblNgayToChuc.Location = new Point(20, 65);
            lblNgayToChuc.Name = "lblNgayToChuc";
            lblNgayToChuc.Size = new Size(100, 23);
            lblNgayToChuc.TabIndex = 2;
            lblNgayToChuc.Text = "Ngày tổ chức:";
            // 
            // dtpNgayToChuc
            // 
            dtpNgayToChuc.Format = DateTimePickerFormat.Short;
            dtpNgayToChuc.Location = new Point(125, 65);
            dtpNgayToChuc.Name = "dtpNgayToChuc";
            dtpNgayToChuc.Size = new Size(250, 23);
            dtpNgayToChuc.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(600, 105);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
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
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(500, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = true;
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
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(100, 105);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTenSuKien
            // 
            lblTenSuKien.Location = new Point(20, 30);
            lblTenSuKien.Name = "lblTenSuKien";
            lblTenSuKien.Size = new Size(100, 23);
            lblTenSuKien.TabIndex = 10;
            lblTenSuKien.Text = "Tên sự kiện:";
            // 
            // txtTenSuKien
            // 
            txtTenSuKien.Location = new Point(125, 27);
            txtTenSuKien.Name = "txtTenSuKien";
            txtTenSuKien.Size = new Size(250, 23);
            txtTenSuKien.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSuKien);
            groupBox2.Location = new Point(12, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Sự kiện";
            // 
            // dgvSuKien
            // 
            dgvSuKien.AllowUserToAddRows = false;
            dgvSuKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuKien.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSuKien, colNgayToChuc, colSanVanDong });
            dgvSuKien.Dock = DockStyle.Fill;
            dgvSuKien.Location = new Point(3, 19);
            dgvSuKien.Name = "dgvSuKien";
            dgvSuKien.RowHeadersWidth = 51;
            dgvSuKien.Size = new Size(770, 236);
            dgvSuKien.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSuKien
            // 
            colTenSuKien.HeaderText = "Tên Sự Kiện";
            colTenSuKien.MinimumWidth = 6;
            colTenSuKien.Name = "colTenSuKien";
            // 
            // colNgayToChuc
            // 
            colNgayToChuc.HeaderText = "Ngày Tổ Chức";
            colNgayToChuc.MinimumWidth = 6;
            colNgayToChuc.Name = "colNgayToChuc";
            // 
            // colSanVanDong
            // 
            colSanVanDong.HeaderText = "Tên Sân";
            colSanVanDong.MinimumWidth = 6;
            colSanVanDong.Name = "colSanVanDong";
            // 
            // frmSuKien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grpThongTin);
            Name = "frmSuKien";
            Text = "Quản lý Sự kiện";
            Load += frmSuKien_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSuKien).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtTenSuKien;
        private System.Windows.Forms.Label lblTenSuKien;
        private System.Windows.Forms.DateTimePicker dtpNgayToChuc;
        private System.Windows.Forms.Label lblNgayToChuc;
        private System.Windows.Forms.ComboBox cboSanVanDong;
        private System.Windows.Forms.Label lblSanVanDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSuKien;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSuKien;
        private DataGridViewTextBoxColumn colNgayToChuc;
        private DataGridViewTextBoxColumn colSanVanDong;
    }
}