using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LapTrinhQuanLy_QuanLyDatVeSVD.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "HoaDonVe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "HoaDonVe");
        }
    }
}
