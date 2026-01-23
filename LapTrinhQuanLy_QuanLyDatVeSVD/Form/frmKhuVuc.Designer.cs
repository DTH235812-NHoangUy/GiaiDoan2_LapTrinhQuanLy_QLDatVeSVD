using System.Drawing;
using System.Windows.Forms;

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Form
{
    partial class frmKhuVuc
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
            dgvKhuVuc = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenKhuVuc = new DataGridViewTextBoxColumn();
            colTenSVD = new DataGridViewTextBoxColumn();
            grpThongTin = new GroupBox();
            cboSanVanDong = new ComboBox();
            lblSVD = new Label();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTenKhuVuc = new Label();
            txtTenKhuVuc = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvKhuVuc);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 278);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Khu Vực";
            // 
            // dgvKhuVuc
            // 
            dgvKhuVuc.AllowUserToAddRows = false;
            dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhuVuc.Columns.AddRange(new DataGridViewColumn[] { colID, colTenKhuVuc, colTenSVD });
            dgvKhuVuc.Dock = DockStyle.Fill;
            dgvKhuVuc.Location = new Point(3, 19);
            dgvKhuVuc.Name = "dgvKhuVuc";
            dgvKhuVuc.Size = new Size(770, 256);
            dgvKhuVuc.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colTenKhuVuc
            // 
            colTenKhuVuc.HeaderText = "Tên Khu Vực";
            colTenKhuVuc.Name = "colTenKhuVuc";
            // 
            // colTenSVD
            // 
            colTenSVD.HeaderText = "Thuộc Sân Vận Động";
            colTenSVD.Name = "colTenSVD";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(cboSanVanDong);
            grpThongTin.Controls.Add(lblSVD);
            grpThongTin.Controls.Add(btnThoat);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnHuyBo);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(lblTenKhuVuc);
            grpThongTin.Controls.Add(txtTenKhuVuc);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(776, 130);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Khu Vực";
            // 
            // cboSanVanDong
            // 
            cboSanVanDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanVanDong.FormattingEnabled = true;
            cboSanVanDong.Location = new Point(480, 27);
            cboSanVanDong.Name = "cboSanVanDong";
            cboSanVanDong.Size = new Size(220, 23);
            cboSanVanDong.TabIndex = 1;
            // 
            // lblSVD
            // 
            lblSVD.AutoSize = true;
            lblSVD.Location = new Point(380, 30);
            lblSVD.Name = "lblSVD";
            lblSVD.Size = new Size(82, 15);
            lblSVD.TabIndex = 9;
            lblSVD.Text = "Sân vận động:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Location = new Point(570, 80);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 30);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(390, 80);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(255, 128, 0);
            btnHuyBo.Location = new Point(480, 80);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 30);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Black;
            btnXoa.ForeColor = Color.Yellow;
            btnXoa.Location = new Point(300, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 128, 128);
            btnSua.ForeColor = Color.IndianRed;
            btnSua.Location = new Point(210, 80);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 0, 192);
            btnThem.Location = new Point(120, 80);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTenKhuVuc
            // 
            lblTenKhuVuc.AutoSize = true;
            lblTenKhuVuc.Location = new Point(20, 30);
            lblTenKhuVuc.Name = "lblTenKhuVuc";
            lblTenKhuVuc.Size = new Size(73, 15);
            lblTenKhuVuc.TabIndex = 8;
            lblTenKhuVuc.Text = "Tên khu vực:";
            // 
            // txtTenKhuVuc
            // 
            txtTenKhuVuc.Location = new Point(120, 27);
            txtTenKhuVuc.Name = "txtTenKhuVuc";
            txtTenKhuVuc.Size = new Size(220, 23);
            txtTenKhuVuc.TabIndex = 0;
            // 
            // frmKhuVuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grpThongTin);
            Name = "frmKhuVuc";
            Text = "Quản lý Khu Vực";
            Load += KhuVuc_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhuVuc).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.ComboBox cboSanVanDong;
        private System.Windows.Forms.Label lblSVD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTenKhuVuc;
        private System.Windows.Forms.TextBox txtTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSVD;
    }
}