using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseFull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "SuKien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "SuKien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TrangThaiThanhToan",
                table: "HoaDonVe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BangGia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuKienID = table.Column<int>(type: "int", nullable: false),
                    LoaiVeID = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangGia");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "SuKien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "SuKien");

            migrationBuilder.DropColumn(
                name: "TrangThaiThanhToan",
                table: "HoaDonVe");
        }
    }
}
